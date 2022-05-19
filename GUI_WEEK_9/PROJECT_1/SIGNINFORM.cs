using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.BL;
using Project_1.DL;


namespace Project_1
{
    public partial class SIGNINFORM : Form
    {
        public string Path = "User.txt";
        public SIGNINFORM()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Password = textBox2.Text;
            SIGNUP USER = new SIGNUP(Name, Password);
            SIGNUPDL.AddIntoList(Name, Password);
            SIGNUPDL.AddDataIntoFile(Path, USER);
            MessageBox.Show("Data Enter Successfully");
            SIGNINFORM Temp = new SIGNINFORM();
            this.Hide();
            Temp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIGNIN Sigin = new SIGNIN();
            this.Hide();
            Sigin.Show();

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
