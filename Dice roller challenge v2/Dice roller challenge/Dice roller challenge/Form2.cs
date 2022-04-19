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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string username1;
        public static string username2;

        public static string BrojRundi;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Player_1") { errorProvider1.SetError(textBox1, "Unesite Ime!!!"); }
            else if (textBox2.Text == "Player_2") { errorProvider2.SetError(textBox2, "Unesite Ime!!!"); errorProvider1.Clear(); }
            else if ((BrojRundi!="1") && (BrojRundi!="2") && (BrojRundi!="3"))
            {
                errorProvider3.SetError(comboBox1, "Izaberite broj rundi!!!");
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            else{
                
                username1 = textBox1.Text.ToString();
                username2 = textBox2.Text.ToString();
                this.Hide();
                Form3 fr3 = new Form3();
                fr3.Show();
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrojRundi = comboBox1.SelectedItem.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
        }

        

        

        


    }
}
