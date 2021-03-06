using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();
            SetupTime.Start();
        }

        private void SetupTime_Tick(object sender, EventArgs e)
        {
            FilesSetup.Value = FilesSetup.Value + 2;
            if (FilesSetup.Value == FilesSetup.Maximum)
            {
                SetupTime.Stop();
                ModulesTime.Start();
            }
        }

        private void ModulesTime_Tick(object sender, EventArgs e)
        {
            ModulesSetup.Value = ModulesSetup.Value + 5;
            if (ModulesSetup.Value == ModulesSetup.Maximum)
            {
                ModulesTime.Stop();
            }
            if (FilesSetup.Value == FilesSetup.Maximum && ModulesSetup.Value == ModulesSetup.Maximum)
            {
                MessageBox.Show("Sianala Accentillo is success installed", "Sianala Accentillo Setup");
                Application.Exit();
            }
        }
    }
}
