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
    public partial class frmAutoFetch : Form {

        private int mQueryCount = -1;


        public frmAutoFetch() {
            InitializeComponent();
        }


        public int QueryCount { get { return mQueryCount; } }


        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAutoFetch_Click(object sender, EventArgs e) {

            mQueryCount = (int)nudApnonceQueries.Value;
            this.Close();

        }
    }
}
