using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace shshPatri0tS {

    public class TssChecker {

        private frmMain formMain;

        private string signedVersionsURL = "https://api.ipsw.me/v2.1/firmwares.json/condensed";

        public static string pathIpsw = Path.Combine(Directory.GetCurrentDirectory(), "ipsw");
        public static string pathShsh = Path.Combine(Directory.GetCurrentDirectory(), "shsh");

        private bool isSuccess = false;


        public TssChecker(frmMain form) {
            formMain = form;
        }


        public bool DownloadIpsw(string url, string path) {

            formMain.Invoke((MethodInvoker)delegate {
                formMain.AppendOutput("Downloading IPSW...");
            });

            try {

                using (WebClient wc = new WebClient()) {

                    wc.DownloadProgressChanged += frmMain.WebClient_DownloadProgressChanged; // TODO: Implement UI updates

                    wc.DownloadFile(url, path);

                    wc.DownloadProgressChanged -= frmMain.WebClient_DownloadProgressChanged;

                }

            } catch (Exception ex) {

                throw new Exception("Unable to downloaded the IPSW file. Operation cancelled.");

            }


            formMain.Invoke((MethodInvoker)delegate {
                formMain.AppendOutput("Finished downloading IPSW.");
            });
            
            return true;

        }


        public bool SaveBlobs(AppleDevice device, string boardConfig, long decECID, string apnonce, string profile) {
            
            // int countApnonce = apnonce.Length;

            string json = "";

            using (WebClient wc = new WebClient()) {
                json = wc.DownloadString(signedVersionsURL);
            }

            File.WriteAllText(Path.Combine(Path.GetTempPath(), "firmware.json"), json);


            JObject allFirmwares = JObject.Parse(json);
            JToken deviceFirmwares = allFirmwares["devices"][device.Identifier]["firmwares"];

            

            for (int i = 0; i < deviceFirmwares.Count(); i++) {

                Firmware fw = new Firmware(deviceFirmwares[i]);

                if (!fw.Signed)
                    continue;


                //$currentFirmware = $firmware[$a];
                //$savePath = 'shsh/'.$deviceInfo['deviceECID'].'/'.$currentFirmware['version'];
                //             if (!file_exists($savePath)) {
                //                 mkdir($savePath, 0777, true);
                //             }

                //             if (!file_exists($savePath.'/randomapnonce')) {
                //                 mkdir($savePath.'/randomapnonce', 0777, true);
                //             }


                string pathIpswIdentifier = Path.Combine(pathIpsw, device.Identifier);
                string pathIpswBoard = Path.Combine(pathIpswIdentifier, boardConfig);

                Directory.CreateDirectory(pathIpswBoard);
                string pathIpswFile = Path.Combine(pathIpswBoard, fw.Filename);

                while (true) {

                    if (!File.Exists(pathIpswFile))
                        DownloadIpsw(fw.Url, pathIpswFile);


                    byte[] hashValue = null;

                    using (FileStream fileStream = File.OpenRead(pathIpswFile)) {

                        fileStream.Position = 0;
                        hashValue = SHA1.Create().ComputeHash(fileStream);

                    }

                    string strHash = "";

                    for (int b = 0; b < hashValue.Length; b++)
                        strHash += String.Format("{0:X2}", hashValue[b]);


                    if (!String.Equals(fw.Sha1Sum, strHash, StringComparison.OrdinalIgnoreCase)) {

                        DialogResult redownload = MessageBox.Show("The downloaded IPSW file's hash does not match the hash on-record. Would you like to delete and re-download the file '" + fw.Filename + "'?", "", MessageBoxButtons.YesNo);

                        if (redownload == DialogResult.Yes) {
                            File.Delete(pathIpswFile);
                            continue;
                        }

                        throw new Exception("The downloaded IPSW file's hash does not match the hash on-record. Operation cancelled.");

                    } else // Hashes matched; exit the while() loop.
                        break;
                    
                }


                formMain.Invoke((MethodInvoker)delegate {
                    formMain.AppendOutput("Hash compare successful.");
                });


                string manifestFilename = fw.Filename.Replace("_Restore.ipsw", "_BuildManifest.plist");
                string manifestFullPath = Path.Combine(pathIpswBoard, manifestFilename);

                if (!File.Exists(manifestFullPath)) {

                    using (ZipArchive archive = ZipFile.OpenRead(pathIpswFile)) {

                        foreach (ZipArchiveEntry entry in archive.Entries) {

                            if (entry.FullName == "BuildManifest.plist") {

                                entry.ExtractToFile(manifestFullPath);

                                formMain.Invoke((MethodInvoker)delegate {
                                    formMain.AppendOutput("Extracted BuildManifest file.");
                                });

                                break;

                            }

                        }

                    }

                }


                string pathShshProfile = Path.Combine(pathShsh, profile);

                Directory.CreateDirectory(pathShsh);
                Directory.CreateDirectory(pathShshProfile);

                StringBuilder cmdArgs = new StringBuilder(@"/C tsschecker_v212\tsschecker_windows");
                cmdArgs.Append(" -d " + device.Identifier);
                cmdArgs.Append(" -e " + decECID);
                cmdArgs.Append(" -i " + fw.Version);
                cmdArgs.Append(" --buildid " + fw.BuildId);

                if (boardConfig.Length > 0)
                    cmdArgs.Append(" --boardconfig " + boardConfig);

                if (apnonce.Length > 0)
                    cmdArgs.Append(" --apnonce " + apnonce);
                
                cmdArgs.Append(" -m ipsw\\" + device.Identifier + "\\" + boardConfig + "\\" + manifestFilename);

                cmdArgs.Append(" --save-path shsh\\" + profile);
                cmdArgs.Append(" -s");

                // testRetVal.Add(cmdArgs.ToString());


                Process process = new Process();

                process.EnableRaisingEvents = true;
                process.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(tsschecker_ErrorDataReceived);
                process.OutputDataReceived += new DataReceivedEventHandler(tsschecker_OutputDataReceived);
                process.Exited += new System.EventHandler(tsschecker_Exited);

                ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", cmdArgs.ToString());

                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;

                process.StartInfo = startInfo;
                process.Start();

                process.BeginErrorReadLine();
                process.BeginOutputReadLine();


                //             for ($b = 0; $b < $countApnonce; $b++) {
                //	$currentApnonce = $apnonce[$b];
                //                 if (!file_exists($savePath.'/apnonce-'.$currentApnonce)) {
                //                     mkdir($savePath.'/apnonce-'.$currentApnonce, 0777, true);
                //                 }

                //	$cmd = "./bin/tsschecker";
                //	$cmd.= " -d ".escapeshellarg($deviceInfo['deviceIdentifier']);
                //	$cmd.= " -e ".escapeshellarg($deviceInfo['deviceECID']);
                //	$cmd.= " -i ".escapeshellarg($currentFirmware['version']);
                //	$cmd.= " --buildid ".escapeshellarg($currentFirmware['buildid']);
                //	$cmd.= " --apnonce ".$currentApnonce;
                //	$cmd.= " --save-path ".$savePath.'/apnonce-'.$currentApnonce;
                //	$cmd.= " -s ";

                //                 shell_exec($cmd);

                //             }

            }


            return isSuccess;

        }


        private void tsschecker_ErrorDataReceived(object sender, DataReceivedEventArgs e) {

            if (e == null || e.Data == null)
                return;


            formMain.Invoke(new Action(() => { MessageBox.Show(formMain, "[noncestatistsics] " + e.Data); }));

        }

        private void tsschecker_OutputDataReceived(object sender, DataReceivedEventArgs e) {

            if (e == null || e.Data == null)
                return;

            if (e.Data.StartsWith("Saved shsh blobs!"))
                isSuccess = true;


            formMain.Invoke((MethodInvoker)delegate {
                formMain.AppendOutput(e.Data);
            });

        }

        private void tsschecker_Exited(object sender, EventArgs e) {


            formMain.Invoke(new Action(() => {
                formMain.ToggleInteractableUI(true);
            }));

        }

    }


    public class Firmware {

        private string mVersion;
        private string mBuildId;

        private bool mSigned;

        private string mUrl;
        private string mFilename;
        private string mSize;

        private string mSha1Sum;
        private string mMd5Sum;

        private string mReleaseDate;
        private string mUploadDate;


        public Firmware(JToken fw) {

            mVersion = fw.Value<string>("version");
            mBuildId = fw.Value<string>("buildid");

            mSigned = fw.Value<bool>("signed");

            mUrl = fw.Value<string>("url");
            mFilename = fw.Value<string>("filename");
            mSize = fw.Value<string>("size");

            mSha1Sum = fw.Value<string>("sha1sum");
            mMd5Sum = fw.Value<string>("md5sum");

            mReleaseDate = fw.Value<string>("releasedate");
            mUploadDate = fw.Value<string>("uploaddate");

        }


        public string Version { get { return mVersion; } }
        public string BuildId { get { return mBuildId; } }

        public bool Signed { get { return mSigned; } }

        public string Url { get { return mUrl; } }
        public string Filename { get { return mFilename; } }
        public string Size { get { return mSize; } }

        public string Sha1Sum { get { return mSha1Sum; } }
        public string Md5Sum { get { return mMd5Sum; } }

        public string ReleaseDate { get { return mReleaseDate; } }
        public string UploadDate { get { return mUploadDate; } }

    }

}
