using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(Form3.Win==1)
            {
                label16.BackColor = Color.DodgerBlue;
                label16.Text = Form2.username1;
            }
            else if (Form3.Win == 2)
            {
                label16.BackColor = Color.Red;
                label16.Text = Form2.username2;
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
           
        }
    }
}
