using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CammsEngine;

namespace CammsTestEnviroment
{
    public partial class Form1 : Form
    {
        public Fuel fuel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fuel == null)
            {
                fuel = new Fuel();
                label1.Text = fuel.Status.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fuel != null)
            {
                fuel.SupplierID = int.Parse(textBox1.Text);
                label1.Text = fuel.Status.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(fuel != null)
            {
                fuel.Status = ITTech24Tools.Database.RecordStatus.Loaded;
                label1.Text = fuel.Status.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(fuel != null)
            {
                fuel.Status = ITTech24Tools.Database.RecordStatus.Saved;
                label1.Text = fuel.Status.ToString();
            }
        }
    }
}
