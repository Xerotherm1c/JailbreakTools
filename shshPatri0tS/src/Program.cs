using System;
using System.Threading;
using System.Windows.Forms;

using Tulpep.NotificationWindow;


namespace shshPatri0tS {

    static class Program {

        static System.Threading.Mutex singleton = new Mutex(true, "shshPatri0tS");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {

            if (!singleton.WaitOne(TimeSpan.Zero, true)) {
                MessageBox.Show("You can only run once instance of shshPatri0tS at any given time. If you do not see the application window, shshPatri0tS may be running in the background if you turned on the automatic blob checking feature.");
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(args));

        }

    }

}
