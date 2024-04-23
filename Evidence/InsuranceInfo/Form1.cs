using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientEntry fce=new frmClientEntry();
            fce.Show();
            fce.MdiParent= this;
        }

        private void newPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPolicy fce = new frmPolicy();
            fce.Show();
            fce.MdiParent = this;

        }

        private void durationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDurationEntry fce = new frmDurationEntry();
            fce.Show();
            fce.MdiParent = this;


        }

        private void entryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmClaimEntry fce = new frmClaimEntry();
            fce.Show();
            fce.MdiParent = this;

        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInformationReport fce = new frmClientInformationReport();
            fce.Show();
            fce.MdiParent = this;
        }
    }
}
