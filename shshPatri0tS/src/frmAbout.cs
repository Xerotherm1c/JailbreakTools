using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shshPatri0tS {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
        }


        private void frmAbout_Load(object sender, EventArgs e) {

        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            System.Diagnostics.Process.Start("https://github.com/Xerotherm1c/JailbreakTools");

        }

        private void linkTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            System.Diagnostics.Process.Start("https://twitter.com/Xerotherm1c");

        }

    }

}
