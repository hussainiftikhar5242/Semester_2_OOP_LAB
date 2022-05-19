using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.DL;
using Project_1.BL;

namespace Project_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SIGNUPDL.ReadDataFromFile("User.txt");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            if (Button1.Checked)
            {
                SIGNINFORM SIgn = new SIGNINFORM();
                this.Hide();
                SIgn.Show();
            }
            if(Button2.Checked)
            {
                SIGNIN Sigin = new SIGNIN();
                this.Hide();
                Sigin.Show();
            }
            if(radioButton1.Checked)
            {
                Environment.Exit(0);
            }

        }
    }
}
