using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hasifer
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lnkCredits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://crackingking.com/member.php?action=profile&uid=2");
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHash.Clear();
            txtIdentity.Clear();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHash.Text.Length > 0)
                {
                    txtIdentity.Text = Identification.IdentifyHash(txtHash.Text);
                }
                else
                {
                    MessageBox.Show("Please fill out the form correctly!");
                }
            }
            catch { }
        }
    }
}
