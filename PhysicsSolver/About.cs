using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicsSolver
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklblGithub.LinkVisited = true;
            var link = new ProcessStartInfo()
            {
                FileName = "https://github.com/SepehrHr/PhysicsSolver.git",
                UseShellExecute = true
            };
            Process.Start(link);
        }
    }
}
