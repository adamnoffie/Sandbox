using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCrypter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtResult.Text = 
                BCrypt.HashPassword(txtToCrypt.Text, BCrypt.GenerateSalt((int)udSaltGenPasses.Value));
        }
    }
}
