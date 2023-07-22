using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MDIParent1 : Form
    {


        public MDIParent1()
        {
            InitializeComponent();
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void araçKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form2 = new Form6();
            form2.MdiParent = this;
            form2.Show();

        }

        private void kiraİşlemlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form2 = new Form4();
            form2.MdiParent = this;
            form2.Show();
        }

        private void araçListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaraclisteleme form2 = new formaraclisteleme();
            form2.MdiParent = this;
            form2.Show();
        }

        private void kiralanabilecekAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void kiraGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
