﻿using AimlabDataManager.Controller;
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

            string last100 = TxtLast100.Text;
            string deviation = txtDeviation.Text;

            string showAvg = (lblShowAvg.Text = "");
            string ShowRecord = (lblShowRecord.Text = "");
            
                string selectedTask = comboTasks.SelectedIndex.ToString();
                c = new MainController(selectedTask ,ref last100, ref deviation, ref showAvg, ref ShowRecord);

         
               
        

            TxtLast100.Text = last100;
            txtDeviation.Text = deviation;
            lblShowAvg.Text = showAvg;
            lblShowRecord.Text = ShowRecord;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}