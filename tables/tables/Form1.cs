using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gfProducts.Items.Add("HDPE Pipe(IPPI Design-Flow®)");
            gfProducts.Items.Add("Conventional PE Fusion Fittings");
            gfProducts.Items.Add("Electrofusion Fittings &Equipment ");
            gfProducts.Items.Add("Conventional PE Fusion Equipment ");
            gfProducts.Items.Add("Factory Mutual Approved Products");
            gfProducts.Items.Add("Meter Connection Products");
            gfProducts.Items.Add("Risers & Transitions ");
            gfProducts.Items.Add("Steel Mechanical Fittings");
            gfProducts.Items.Add("Flange Insulation Products ");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
