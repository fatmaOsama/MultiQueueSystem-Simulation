﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public SimulationSystem System;
        public ReadFile Reader;

        public Form1()
        {
            InitializeComponent();
            System = new SimulationSystem();
            Reader = new ReadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.ReadInput(Reader);
            System.Simulate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Stable(System).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string TestingResults = TestingManager.Test(System, Constants.FileNames.TestCase1);
            MessageBox.Show(TestingResults);
        }
    }

}
