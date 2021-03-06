using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class Verify : Form
    {
        public Verify()
        {
            InitializeComponent();
        }

        private void CancelClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InstallClick_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
