using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using Tulpep.NotificationWindow;


namespace shshPatri0tS {

    public partial class frmMain : Form {

        private string[] loadArgs;
        private bool isScheduled = false;
        private ArrayList successfulSaves = new ArrayList();

        private TssChecker tss;

        private DeviceProfile currentProfile = new DeviceProfile();
        private List<AppleDevice> currentDevices = null;

        private Dictionary<string, int> apnonceStats = new Dictionary<string, int>();
        private int totalApnonceQueries;

        private string pathProfiles;
        private string activeProfile;


        public frmMain(string[] args) {

            InitializeComponent();

            loadArgs = args;
            isScheduled = (args.Length > 0); // && args[0] == "1"

        }

        private void frmMain_Load(object sender, EventArgs e) {

            tss = new TssChecker(this);

            cbECIDType.SelectedIndex = 0;
            cbDevice.SelectedIndex = 0;


            pathProfiles = Path.Combine(Directory.GetCurrentDirectory(), "Profiles");

            RefreshProfiles();

            if (loadArgs.Length > 0)
                RunSilent(); // loadArgs[0] == "1"

        }


        private void RunSilent() {

            BeginInvoke(new MethodInvoker(delegate {
                Hide();
            }));


            Random rnd = new Random();
            int minToStall = rnd.Next(1, 29);

            Thread.Sleep(minToStall * 60 * 1000);


            for (int i = 0; i < cbProfiles.Items.Count; i++) {

                cbProfiles.SelectedIndex = i;
                btnLoadProfile_Click(null, null);

                if (chkSchedulingEnabled.Checked)
                    btnSaveBlobs_Click(null, null);

                Thread.Sleep(rnd.Next(1, 10) * 1000);

            }


            if (isScheduled) {

                Thread.Sleep(2500);

                PopupNotifier popup = PopupHelper.GeneratePopup("Shsh blobs for autosave-enabled profiles downloaded successfully."); // " + string.Join(", ", successfulSaves.ToArray())); // TODO: Fix [System.String.Arraylist]
                popup.Popup(); // Popup the condensed notification

            }


            timerSilentWait.Enabled = true;

        }


        private void RefreshProfiles() {

            cbProfiles.Items.Clear();

            Directory.CreateDirectory(pathProfiles);
            string[] profiles = Directory.GetFiles(pathProfiles);

            for (int i = 0; i < profiles.Length; i++) {

                string profile = Path.GetFileNameWithoutExtension(profiles[i]);
                cbProfiles.Items.Add(profile);

            }

        }

        private void cbProfiles_SelectedValueChanged(object sender, EventArgs e) {

            btnLoadProfile.Enabled = (cbProfiles.Text.Length > 0);

        }


        private void btnLoadProfile_Click(object sender, EventArgs e) {

            string pathToLoad = Path.Combine(pathProfiles, cbProfiles.Text + ".txt");

            if (!File.Exists(pathToLoad)) {
                MessageBox.Show("The seleted profile '" + cbProfiles.Text + "' does not exist.");
                return;
            }


            try {

                string[] profileLines = File.ReadAllLines(pathToLoad);
                currentProfile = new DeviceProfile(cbProfiles.Text, profileLines);

                if (currentProfile == null || currentProfile.ECID == null || currentProfile.ECID.Length == 0)
                    throw new Exception("There was an issue loading the selected profile '" + cbProfiles.Text + "'.");


                tbECID.Text = currentProfile.ECID;
                cbDevice.SelectedItem = currentProfile.DeviceType;

                for (int i = 0; i < cbModel.Items.Count; i++) {

                    if (cbModel.GetItemText(cbModel.Items[i]).Contains(currentProfile.Identifier)) {

                        cbModel.SelectedIndex = i;
                        break;

                    }

                }

                cbBoardConfig.SelectedItem = currentProfile.InternalName;


                cbApnonce.Items.Clear();

                for (int i = 0; i < currentProfile.ApnonceList.Length; i++)
                    cbApnonce.Items.Add(currentProfile.ApnonceList[i]);

                chkApnonce.Checked = (currentProfile.Apnonce.Length > 0); // Update checkbox.Checked prior to Apnonce; otherwise, Apnonce will be blanked out on CheckedChanged()
                cbApnonce.SelectedItem = currentProfile.Apnonce;

                chkSchedulingEnabled.Checked = currentProfile.SchedulingEnabled;

            } catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);

            }

        }

        private void btnSaveProfile_Click(object sender, EventArgs e) {

            if (cbProfiles.Text == "") {

                MessageBox.Show("Please enter a profile name before attempting to save the profile.");
                cbProfiles.Focus();

                return;

            }

            if (tbECID.Text.Length == 0) {

                MessageBox.Show("You must enter a device ECID before attempting to save the profile.");
                tbECID.Focus();

                return;

            }


            if (chkSchedulingEnabled.Checked) {

                using (Microsoft.Win32.TaskScheduler.TaskService ts = new Microsoft.Win32.TaskScheduler.TaskService()) {

                    Microsoft.Win32.TaskScheduler.Task t = ts.GetTask(frmAutosaves.taskName);

                    if (t == null) {

                        MessageBox.Show("You selected to automatically check and save blobs for this profile, but you haven't set up autochecking. If you would like to use the autocheck feature, please enable it now.");

                        frmAutosaves formAutosaves = new frmAutosaves();
                        formAutosaves.ShowDialog();

                    }

                }

            }


            try {

                string identifier = "";

                if (cbModel.Text.Length > 0) {

                    identifier = cbModel.Text.Substring(cbModel.Text.IndexOf("(") + 1);
                    identifier = identifier.Substring(0, identifier.LastIndexOf(")"));

                }


                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SchedulingEnabled:" + chkSchedulingEnabled.Checked);

                sb.AppendLine("ECID:" + tbECID.Text);
                sb.AppendLine("DeviceType:" + cbDevice.Text);
                sb.AppendLine("Identifier:" + identifier);
                sb.AppendLine("InternalName:" + cbBoardConfig.Text);
                sb.AppendLine("Apnonce:" + cbApnonce.Text);

                sb.Append("ApnonceList:");

                for (int i = 0; i < cbApnonce.Items.Count; i++) {

                    string apnonce = cbApnonce.GetItemText(cbApnonce.Items[i]);

                    if (apnonce.Length == 0)
                        continue;

                    sb.Append(";" + apnonce); // Preceeding the apnonce with a semicolon will handle adding the first blank item automatically

                }


                File.WriteAllText(Path.Combine(pathProfiles, cbProfiles.Text + ".txt"), sb.ToString());


                PopupNotifier popup = PopupHelper.GeneratePopup("The profile was saved successfully.");
                popup.Popup();

            } catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);

            }


            RefreshProfiles();

        }


        private void cbECIDType_SelectedIndexChanged(object sender, EventArgs e) {

            tbECID.Text = tbECID.Text.Trim();

            if (tbECID.Text.Length == 0) {
                tbECID.BackColor = System.Drawing.Color.White;
                return;
            }


            long decECID = -1;

            if (cbECIDType.SelectedIndex == 0) {

                if (Regex.IsMatch(tbECID.Text, @"^\d+$")) {

                    if (!long.TryParse(tbECID.Text, out decECID)) {

                        tbECID.BackColor = System.Drawing.Color.LightSalmon;
                        return;

                    }


                    tbECID.Text = decECID.ToString("X");
                    tbECID.BackColor = System.Drawing.Color.White;

                } else if (Regex.IsMatch(tbECID.Text, @"\A\b[0-9a-fA-F]+\b\Z")) {

                    tbECID.BackColor = System.Drawing.Color.White;

                }

            } else { // if (cbECIDType.SelectedIndex == 1) {

                if (Regex.IsMatch(tbECID.Text, @"^\d+$")) {

                    tbECID.BackColor = System.Drawing.Color.White;
                    return;

                }


                if (!long.TryParse(tbECID.Text, System.Globalization.NumberStyles.HexNumber, null, out decECID)) {

                    tbECID.BackColor = System.Drawing.Color.LightSalmon;
                    return;

                }


                tbECID.Text = decECID.ToString();
                tbECID.BackColor = System.Drawing.Color.White;

            }

        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e) {

            switch (cbDevice.SelectedIndex) {

                case 0:

                    updateDeviceModelItems(AppleDevices.iPhones);
                    break;

                case 1:

                    updateDeviceModelItems(AppleDevices.iPods);
                    break;

                case 2:

                    updateDeviceModelItems(AppleDevices.iPads);
                    break;

                case 3:

                    updateDeviceModelItems(AppleDevices.appleTVs);
                    break;

                default:

                    MessageBox.Show("Unknown device type.");
                    break;

            }

        }

        private void updateDeviceModelItems(List<AppleDevice> devices) {

            cbModel.Items.Clear();

            for (int i = 0; i < devices.Count; i++) {
                cbModel.Items.Add(devices[i].Generation + " (" + devices[i].Identifier + ")");
            }

            currentDevices = devices;
            cbModel.SelectedIndex = 0;

        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e) {

            cbBoardConfig.Items.Clear();

            if (cbModel.SelectedIndex > -1)
                cbBoardConfig.Items.AddRange(currentDevices[cbModel.SelectedIndex].InternalName.Split(';'));


            if (cbBoardConfig.Items.Count == 1)
                cbBoardConfig.SelectedIndex = 0;


            bool isBoardConfigEnabled = false;

            if (cbDevice.SelectedIndex == 0) // If dealing with a special case where board config is necessary (such as an iPhone 6S)
                isBoardConfigEnabled = (cbModel.SelectedIndex >= 15 && cbModel.SelectedIndex <= 17);

            cbBoardConfig.Enabled = isBoardConfigEnabled;

        }


        private void chkApnonce_CheckedChanged(object sender, EventArgs e) {

            cbApnonce.Enabled = chkApnonce.Checked;

            if (cbApnonce.Items.Count > 0)
                cbApnonce.SelectedIndex = 0;

        }


        public void ToggleInteractableUI(bool enabled = true) {

            btnLoadProfile.Enabled = enabled;
            cbProfiles.Enabled = enabled;
            btnSaveProfile.Enabled = enabled;

            btnAutoFetch.Enabled = enabled;
            btnSaveBlobs.Enabled = enabled;

            cbECIDType.Enabled = enabled;
            tbECID.Enabled = enabled;

            cbDevice.Enabled = enabled;
            cbModel.Enabled = enabled;
            cbBoardConfig.Enabled = enabled;

            chkApnonce.Enabled = enabled;
            cbApnonce.Enabled = (enabled ? chkApnonce.Checked : false);

            chkSchedulingEnabled.Enabled = enabled;

            menuStrip1.Enabled = enabled;

            this.Refresh();

        }


        private void btnAutoFetch_Click(object sender, EventArgs e) {

            frmAutoFetch formAutoFetch = new frmAutoFetch();

            formAutoFetch.ShowDialog();

            if (formAutoFetch.QueryCount == -1)
                return;



            ToggleInteractableUI(false);

            totalApnonceQueries = formAutoFetch.QueryCount;
            formAutoFetch.Dispose();

            pbProgress.Value = 0;
            pbProgress.Maximum = 90 + totalApnonceQueries;


            apnonceStats.Clear();

            cbApnonce.Items.Clear();
            cbApnonce.Items.Add("");


            Process process = new Process();

            process.EnableRaisingEvents = true;
            process.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(nonceStats_ErrorDataReceived);
            process.OutputDataReceived += new DataReceivedEventHandler(nonceStats_OutputDataReceived);
            process.Exited += new System.EventHandler(nonceStats_Exited);

            string cmdArgs = @"/C noncestatistics_v0.2\noncestatistics_windows -t " + totalApnonceQueries + " FILE last_noncestats.txt";
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", cmdArgs);

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;

            process.StartInfo = startInfo;
            process.Start();

            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            while (pbProgress.Value < 30) {

                pbProgress.Increment(1);
                Thread.Sleep(100);

            }

        }


        void nonceStats_ErrorDataReceived(object sender, DataReceivedEventArgs e) {

            if (e == null || e.Data == null)
                return;


            this.Invoke(new Action(() => { MessageBox.Show(this, "[noncestatistsics] " + e.Data); }));

        }

        void nonceStats_OutputDataReceived(object sender, DataReceivedEventArgs e) {

            if (e == null || e.Data == null)
                return;


            rtbOutput.Invoke((MethodInvoker)delegate {
                rtbOutput.AppendText(e.Data + "\n");
                rtbOutput.Refresh();
            });


            if (e.Data.StartsWith("Identified device as ")) {

                string foundDevice = e.Data.Substring(21);
                foundDevice = foundDevice.Substring(0, foundDevice.IndexOf(" in")).Replace(", ", ";");

                string[] deviceInfo = foundDevice.Split(';');

                string deviceType = deviceInfo[1].DeleteNums().Delete(",");


                pbProgress.Invoke((MethodInvoker)delegate {

                    while (pbProgress.Value < 55) {

                        pbProgress.Increment(1);
                        Thread.Sleep(150);

                    }

                });



                cbDevice.Invoke((MethodInvoker)delegate {
                    cbDevice.SelectedIndex = cbDevice.Items.IndexOf(deviceType);
                });

                cbModel.Invoke((MethodInvoker)delegate {

                    for (int i = 0; i < cbModel.Items.Count; i++) {

                        if (cbModel.GetItemText(cbModel.Items[i]).Contains(deviceInfo[1])) {

                            cbModel.SelectedIndex = i;
                            break;

                        }

                    }

                });

                cbBoardConfig.Invoke((MethodInvoker)delegate {

                    for (int i = 0; i < cbBoardConfig.Items.Count; i++) {

                        if (cbBoardConfig.GetItemText(cbBoardConfig.Items[i]).ToLower() == deviceInfo[0].ToLower()) {

                            cbBoardConfig.SelectedIndex = i;
                            break;

                        }

                    }

                });


                return;

            }

            if (e.Data.StartsWith("Getting nonce statistics for device with ECID: ")) {

                tbECID.Invoke((MethodInvoker)delegate {
                    tbECID.Text = "";
                });

                cbECIDType.Invoke((MethodInvoker)delegate {
                    cbECIDType.SelectedIndex = 1;
                });


                int idx = e.Data.LastIndexOf(":") + 1;
                string nsECID = e.Data.Substring(idx, e.Data.Length - idx);


                pbProgress.Invoke((MethodInvoker)delegate {

                    while (pbProgress.Value < 65) {

                        pbProgress.Increment(1);
                        Thread.Sleep(25);

                    }

                });


                tbECID.Invoke((MethodInvoker)delegate {
                    tbECID.Text = nsECID;
                });

                cbECIDType.Invoke((MethodInvoker)delegate {
                    cbECIDType.SelectedIndex = 0;
                });


                return;

            }


            if (e.Data.Contains("ApNonce=")) {

                string apnonce = e.Data.Substring(e.Data.IndexOf("ApNonce=") + 8);

                if (apnonceStats.ContainsKey(apnonce))
                    apnonceStats[apnonce] += 1;
                else
                    apnonceStats.Add(apnonce, 1);


                pbProgress.Invoke((MethodInvoker)delegate {
                    pbProgress.Increment(1);
                });

                return;

            }

        }

        void nonceStats_Exited(object sender, EventArgs e) {

            var sortedApnonceStats = from nonce in apnonceStats orderby nonce.Value descending select nonce;


            pbProgress.Invoke((MethodInvoker)delegate {

                while (pbProgress.Value < pbProgress.Maximum) {

                    pbProgress.Increment(1);
                    Thread.Sleep(15);

                }

            });


            cbApnonce.Invoke((MethodInvoker)delegate {

                for (int i = 0; i < sortedApnonceStats.Count(); i++) {

                    int percent = (sortedApnonceStats.ElementAt(i).Value / totalApnonceQueries * 100);

                    if (i == 0 && percent < 50)
                        MessageBox.Show("Consider re-running the Auto Fetch with a higher number of Apnonce queries.\n\nA maximum frequency of " + percent + "% is less than satisfactory.");

                    cbApnonce.Items.Add(sortedApnonceStats.ElementAt(i).Key + " (" + percent + "%)");

                }

            });


            pbProgress.Invoke((MethodInvoker)delegate {

                while (pbProgress.Value < pbProgress.Maximum) {

                    pbProgress.Increment(1);
                    Thread.Sleep(15);

                }

            });


            Thread.Sleep(1000);

            pbProgress.Invoke((MethodInvoker)delegate {
                pbProgress.Value = 0;
            });

            this.Invoke(new Action(() => {
                ToggleInteractableUI(true);
            }));

        }

        public void AppendOutput(string text, bool appendNewline = true, bool forceRefresh = true) {

            if (text.StartsWith("Saved shsh blobs!")) {

                if (isScheduled)
                    successfulSaves.Add(activeProfile);

                else {

                    PopupNotifier popup = PopupHelper.GeneratePopup("Saved shsh blobs for profile '" + activeProfile + "'.");
                    popup.Popup();

                }

            }


            rtbOutput.AppendText(text + (appendNewline ? "\n" : ""));

            if (forceRefresh)
                rtbOutput.Refresh();

        }


        private void btnSaveBlobs_Click(object sender, EventArgs e) {

            cbProfiles.Text = cbProfiles.Text.Trim();

            if (cbProfiles.Text.Length == 0) {

                MessageBox.Show("Please save your configuration profile before saving blobs. This ensures all blobs are orgtanized accordingly.");
                return;

            }


            tbECID.Text = tbECID.Text.Trim();
            cbApnonce.Text = cbApnonce.Text.Trim();

            string apnonce = cbApnonce.Text;

            if (apnonce.Contains("%")) {

                apnonce = apnonce.Substring(0, apnonce.LastIndexOf('%'));
                apnonce = apnonce.Substring(0, apnonce.LastIndexOf(' ')).Trim();

            }


            long decECID = -1;
            long decNonce = -1;


            if (cbBoardConfig.SelectedIndex == -1) {

                MessageBox.Show("Please select a Board Configuration.");
                return;

            }


            if (apnonce.Length > 0) {

                if (!Regex.IsMatch(apnonce, @"\A\b[0-9a-fA-F]+\b\Z")) {

                    MessageBox.Show("Specified Apnonce (HEX) is invalid.");
                    return;

                }


                //if (!long.TryParse(apnonce, System.Globalization.NumberStyles.HexNumber, null, out decNonce)) {

                //    MessageBox.Show("Specified Apnonce Hex value ('" + apnonce + "') could not be converted to a decimal value.");
                //    return;

                //}

            }


            if (cbECIDType.SelectedIndex == 0) {

                if (!Regex.IsMatch(tbECID.Text, @"\A\b[0-9a-fA-F]+\b\Z")) {

                    MessageBox.Show("Device ECID (HEX) is invalid.");
                    return;

                }


                if (!long.TryParse(tbECID.Text, System.Globalization.NumberStyles.HexNumber, null, out decECID)) {

                    MessageBox.Show("Device ECID Hex value could not be converted to a decimal value.");
                    return;

                }


                try {

                    activeProfile = cbProfiles.Text;
                    successfulSaves = new ArrayList();

                    bool isSuccess = tss.SaveBlobs(currentDevices[cbModel.SelectedIndex], cbBoardConfig.Text, decECID, apnonce, cbProfiles.Text);

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                    return;

                }

            } else { // if (cbECIDType.SelectedIndex == 1) {

                if (!Regex.IsMatch(tbECID.Text, @"^\d+$")) {

                    MessageBox.Show("Device ECID (DEC) is invalid.");
                    return;

                }

            }

        }


        public static void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {

            // pbProgress.Value = 
            Console.WriteLine((int)(e.BytesReceived / e.TotalBytesToReceive) + "%");

        }

        private void modifyAutosavesToolStripMenuItem_Click(object sender, EventArgs e) {

            frmAutosaves formAutosaves = new frmAutosaves();
            formAutosaves.ShowDialog();

        }

        private void llToggleOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            this.Size = new System.Drawing.Size(650, (this.Size.Height == 590 ? 750 : 590));

        }


        private void clearBindedValues() {

            cbProfiles.SelectedIndex = -1;


            tbECID.Text = "";
            cbECIDType.SelectedIndex = 0;

            cbBoardConfig.SelectedIndex = -1;
            cbModel.SelectedIndex = -1;
            cbDevice.SelectedIndex = 0;

            cbApnonce.Text = "";
            chkApnonce.Checked = false;

            chkSchedulingEnabled.Checked = false;

        }

        private void aboutShshPatri0tSToolStripMenuItem_Click(object sender, EventArgs e) {

            DialogResult abandonChanges = MessageBox.Show("If you have any unsaved changes, they will be lost. Are you sure you want to continue?", "New Profile Will Discard Unsaved Changes", MessageBoxButtons.OKCancel);

            if (abandonChanges == DialogResult.Cancel)
                return;


            clearBindedValues();

        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e) {
            btnSaveProfile.PerformClick();
        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e) {

            if (cbProfiles.SelectedIndex < 0) {
                MessageBox.Show("Please select a profile before attempting to delete it.");
                return;
            }


            DialogResult confirmDeleteProfile = MessageBox.Show("Are you sure you want to delete the '" + cbProfiles.Text + "' profile? This cannot be undone.", "Delete Profile (Cannot Be Undone)", MessageBoxButtons.YesNoCancel);

            if (confirmDeleteProfile == DialogResult.Yes) {

                try {

                    File.Delete(Path.Combine(pathProfiles, cbProfiles.Text + ".txt"));


                    PopupNotifier popup = PopupHelper.GeneratePopup("The profile was deleted.");
                    popup.Popup();

                } catch (Exception ex) {

                    MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);

                }


                RefreshProfiles();
                cbProfiles.Text = "";

                clearBindedValues();

            }

        }


        private void iPSWFolderToolStripMenuItem_Click(object sender, EventArgs e) {

            Directory.CreateDirectory(TssChecker.pathIpsw); // Avoid an unhandled exception if the directory does not exist
            Process.Start(TssChecker.pathIpsw);

        }

        private void savedBlobsToolStripMenuItem_Click(object sender, EventArgs e) {

            Directory.CreateDirectory(TssChecker.pathShsh); // Avoid an unhandled exception if the directory does not exist
            Process.Start(TssChecker.pathShsh);

        }

        private void appDirectoryToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start(Directory.GetCurrentDirectory());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aboutShshPatri0tSToolStripMenuItem1_Click(object sender, EventArgs e) {

            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();

        }

        private void timerSilentWait_Tick(object sender, EventArgs e) {

            Thread.Sleep(5000);
            Application.Exit();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

            rtbOutput.SelectionStart = rtbOutput.Text.Length;
            rtbOutput.ScrollToCaret();

        }

        private void llPatreon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            System.Diagnostics.Process.Start("https://www.patreon.com/Xerotherm1c");

        }

    }


    //////////////////////////////////////////////////
    // Extension Methods                            //
    //////////////////////////////////////////////////

    public static class StringExtension {

        public static string Delete(this String str, string toDelete) {
            return str.Replace(toDelete, "");
        }

        public static string DeleteNums(this String str) {
            return str.Delete("0").Delete("1").Delete("2").Delete("3").Delete("4").Delete("5").Delete("6").Delete("7").Delete("8").Delete("9");
        }

    }

}
