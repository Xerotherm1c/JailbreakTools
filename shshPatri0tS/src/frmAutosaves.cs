using System;
using System.Windows.Forms;

using Microsoft.Win32.TaskScheduler;
using System.IO;

using Tulpep.NotificationWindow;


namespace shshPatri0tS {

    public partial class frmAutosaves : Form {

        public static string taskName = "shsh Patri0tS AutoChecking";
        private string taskExecPath = Path.Combine(Directory.GetCurrentDirectory(), System.AppDomain.CurrentDomain.FriendlyName);

        public frmAutosaves() {
            InitializeComponent();
        }


        private void frmAutosaves_Load(object sender, EventArgs e) {

            using (TaskService ts = new TaskService()) {

                Task t = ts.GetTask(taskName);
                
                if (t != null) {

                    TaskDefinition td = t.Definition;
                    string[] tAction = td.Actions[0].ToString().Split(' ');

                    chkEnable.Checked = true;
                    chkCondesneNotifications.Checked = (tAction[tAction.Length - 1] == "1");

                    dtpStartTime.Value = td.Triggers[0].StartBoundary;

                } else {

                    chkEnable_CheckedChanged(null, null);

                    Random rnd = new Random();
                    dtpStartTime.Value = DateTime.Parse(rnd.Next(7, 11) + ":" + (rnd.Next(0, 2) == 1 ? "3" : "0") + "0pm");

                }

            }

        }

        private void chkEnable_CheckedChanged(object sender, EventArgs e) {

            // chkCondesneNotifications.Enabled = chkEnable.Checked;
            gbCheckInterval.Enabled = chkEnable.Checked;

        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e) {

            dtpEndTime.Value = dtpStartTime.Value.AddMinutes(30);

        }


        private void btnCancel_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e) {

            try {

                using (TaskService ts = new TaskService()) {

                    if (chkEnable.Checked) { // Autosaving is being enabled

                        TaskDefinition td = ts.NewTask(); // We do not need to lookup & delete previous task given how RegisterTaskDefinition() works below

                        td.RegistrationInfo.Description = "Automatically check for and download shsh blobs for all enabled profiles.";

                        td.Triggers.Add(new DailyTrigger { DaysInterval = 1, StartBoundary = dtpStartTime.Value });
                        td.Actions.Add(new ExecAction(taskExecPath, (chkCondesneNotifications.Checked ? "1" : "0"), Directory.GetCurrentDirectory()));

                        ts.RootFolder.RegisterTaskDefinition(taskName, td); // This will overwrite any previous task with the given name

                    } else { // Autosaving is being disabled

                        ts.RootFolder.DeleteTask(taskName);

                    }

                }


                PopupNotifier popup = PopupHelper.GeneratePopup("Autosave Settings were updated successfully.");
                popup.Popup();

                this.Close();

            } catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);

            }

        }

    }

}
