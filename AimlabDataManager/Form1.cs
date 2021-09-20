using AimlabDataManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimlabDataManager
{
    public partial class frmMain : Form
    {

        MainController c;
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRecord_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {



        }

        private void comboTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {






            c = new MainController(comboTasks.SelectedIndex.ToString(), txtLast100.Text, txtDeviation.Text, lblShowAvg.Text, lblShowRecord.Text);
            c.sarasa();






        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
