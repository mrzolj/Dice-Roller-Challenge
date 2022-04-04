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
    public partial class Form3 : Form
    {
        Random dice = new Random();
        public static int Win;
        int Rez1;
        int Rez2;
        int i = 0;
        int a = 0;
        int Number1;
        int Number2;
        int Number3;
        int Number4;
        int Number5;
        int Number6;
        int Number7;
        int Number8;
        int Number9;
        int Number10;
        int Number11;
        int Number12;
        int UkRez1 = 0;
        int UkRez2 = 0;
        string username1 = Form2.username1;
        string username2 = Form2.username2;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int BrojRundi =Convert.ToInt32(Form2.BrojRundi);
        int brojac = 1;
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            timer1.Start();
            button1.Hide();
            button2.Show();       
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            Number1 = dice.Next(1, 7);
            Number2 = dice.Next(1, 7);
            Number3 = dice.Next(1, 7);
            Number4 = dice.Next(1, 7);
            Number5 = dice.Next(1, 7);
            Number6 = dice.Next(1, 7);
            

            switch (Number1)
            {
                case 1:
                    pictureBox1.Image = imageList2.Images[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.Image = imageList2.Images[1];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.Image = imageList2.Images[2];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.Image = imageList2.Images[3];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.Image = imageList2.Images[4];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.Image = imageList2.Images[5];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.Image = imageList2.Images[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number2)
            {
                case 1:
                    pictureBox2.Image = imageList2.Images[0];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.Image = imageList2.Images[1];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.Image = imageList2.Images[2];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox2.Image = imageList2.Images[3];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox2.Image = imageList2.Images[4];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox2.Image = imageList2.Images[5];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.Image = imageList2.Images[0];
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number3)
            {
                case 1:
                    pictureBox3.Image = imageList2.Images[0];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.Image = imageList2.Images[1];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.Image = imageList2.Images[2];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox3.Image = imageList2.Images[3];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox3.Image = imageList2.Images[4];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox3.Image = imageList2.Images[5];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox3.Image = imageList2.Images[0];
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number4)
            {
                case 1:
                    pictureBox4.Image = imageList2.Images[0];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox4.Image = imageList2.Images[1];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox4.Image = imageList2.Images[2];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox4.Image = imageList2.Images[3];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox4.Image = imageList2.Images[4];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox4.Image = imageList2.Images[5];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox4.Image = imageList2.Images[0];
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number5)
            {
                case 1:
                    pictureBox5.Image = imageList2.Images[0];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox5.Image = imageList2.Images[1];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox5.Image = imageList2.Images[2];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox5.Image = imageList2.Images[3];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox5.Image = imageList2.Images[4];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox5.Image = imageList2.Images[5];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox5.Image = imageList2.Images[0];
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number6)
            {
                case 1:
                    pictureBox6.Image = imageList2.Images[0];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox6.Image = imageList2.Images[1];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox6.Image = imageList2.Images[2];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox6.Image = imageList2.Images[3];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox6.Image = imageList2.Images[4];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox6.Image = imageList2.Images[5];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox6.Image = imageList2.Images[0];
                    pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            Rez1 = Number1 + Number2 + Number3 + Number4 + Number5 + Number6;
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            UkRez1 = UkRez1 + Rez1;
            label5.Text = UkRez1.ToString();
            i++;
            if (i == 1) 
            { label8.Text = Rez1.ToString();
              label8.Show();

              pictureBox13.Image = imageList2.Images[Number1 - 1];
              pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox14.Image = imageList2.Images[Number2 - 1];
              pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox15.Image = imageList2.Images[Number3 - 1];
              pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox16.Image = imageList2.Images[Number4 - 1];
              pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox17.Image = imageList2.Images[Number5 - 1];
              pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox18.Image = imageList2.Images[Number6 - 1];
              pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 2) 
            { 
              label9.Text = Rez1.ToString();
              label9.Show();

              pictureBox19.Image = imageList2.Images[Number6 - 1];
              pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox20.Image = imageList2.Images[Number5 - 1];
              pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox21.Image = imageList2.Images[Number4 - 1];
              pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox22.Image = imageList2.Images[Number3 - 1];
              pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox23.Image = imageList2.Images[Number2 - 1];
              pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox24.Image = imageList2.Images[Number1 - 1];
              pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 3) 
            { 
              label10.Text = Rez1.ToString();
              label10.Show();

              pictureBox25.Image = imageList2.Images[Number6 - 1];
              pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox26.Image = imageList2.Images[Number5 - 1];
              pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox27.Image = imageList2.Images[Number4 - 1];
              pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox28.Image = imageList2.Images[Number3 - 1];
              pictureBox28.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox29.Image = imageList2.Images[Number2 - 1];
              pictureBox29.SizeMode = PictureBoxSizeMode.StretchImage;
              pictureBox30.Image = imageList2.Images[Number1 - 1];
              pictureBox30.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i >= 3)
            {
                label2.Show();
                if ((a == i))
                {
                    int r1 = Convert.ToInt32(label5.Text);
                    int r2 = Convert.ToInt32(label7.Text);

                    if (r1 > r2) { label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString(); }
                    else if (r2 > r1) { label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString(); }
                    if (brojac == BrojRundi)
                    {
                        int w1 = Convert.ToInt32(label1.Text);
                        int w2 = Convert.ToInt32(label6.Text);
                        if (w1 > w2)
                        {
                            Form4 fr4 = new Form4();
                            Win = 1;
                            this.Hide();
                            fr4.Show();
                        }
                        else if (w2 > w1)
                        {
                            Form4 fr4 = new Form4();
                            Win = 2;
                            this.Hide();
                            fr4.Show();
                        }
                        else if (w1 == w2)
                        {
                            if (BrojRundi == 2) { BrojRundi = 3; }
                            if (BrojRundi == 1) { BrojRundi = 2; }
                            button5.Show();
                        }

                    }
                    else { button5.Show(); }

                    brojac++;
                }
            }
            button2.Hide();
            button3.Hide();
            button1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 fr2=new Form2();
            button5.Hide();
            timer1.Stop();
            timer2.Stop();
            label2.Hide();
            label3.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label12.Hide();
            label11.Hide();
            label4.Hide();
            button2.Hide();  
            label15.Text = Form2.username2;
            label16.Text = Form2.username1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Number7 = dice.Next(1, 7);
            Number8 = dice.Next(1, 7);
            Number9 = dice.Next(1, 7);
            Number10 = dice.Next(1, 7);
            Number11 = dice.Next(1, 7);
            Number12 = dice.Next(1, 7);

            switch (Number7)
            {
                case 1:
                    pictureBox7.Image = imageList1.Images[0];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox7.Image = imageList1.Images[1];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox7.Image = imageList1.Images[2];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox7.Image = imageList1.Images[3];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox7.Image = imageList1.Images[4];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox7.Image = imageList1.Images[5];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox7.Image = imageList1.Images[0];
                    pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number8)
            {
                case 1:
                    pictureBox8.Image = imageList1.Images[0];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox8.Image = imageList1.Images[1];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox8.Image = imageList1.Images[2];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox8.Image = imageList1.Images[3];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox8.Image = imageList1.Images[4];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox8.Image = imageList1.Images[5];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox8.Image = imageList1.Images[0];
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number9)
            {
                case 1:
                    pictureBox9.Image = imageList1.Images[0];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox9.Image = imageList1.Images[1];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox9.Image = imageList1.Images[2];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox9.Image = imageList1.Images[3];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox9.Image = imageList1.Images[4];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox9.Image = imageList1.Images[5];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox9.Image = imageList1.Images[0];
                    pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number10)
            {
                case 1:
                    pictureBox10.Image = imageList1.Images[0];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox10.Image = imageList1.Images[1];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox10.Image = imageList1.Images[2];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox10.Image = imageList1.Images[3];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox10.Image = imageList1.Images[4];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox10.Image = imageList1.Images[5];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox10.Image = imageList1.Images[0];
                    pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number11)
            {
                case 1:
                    pictureBox11.Image = imageList1.Images[0];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox11.Image = imageList1.Images[1];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox11.Image = imageList1.Images[2];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox11.Image = imageList1.Images[3];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox11.Image = imageList1.Images[4];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox11.Image = imageList1.Images[5];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox11.Image = imageList1.Images[0];
                    pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (Number12)
            {
                case 1:
                    pictureBox12.Image = imageList1.Images[0];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox12.Image = imageList1.Images[1];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox12.Image = imageList1.Images[2];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox12.Image = imageList1.Images[3];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox12.Image = imageList1.Images[4];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox12.Image = imageList1.Images[5];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox12.Image = imageList1.Images[0];
                    pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            Rez2 = Number7 + Number8 + Number9 + Number10 + Number11 + Number12;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button4.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            a++;
            UkRez2 = UkRez2 + Rez2;
            label7.Text = UkRez2.ToString();

            if (a == 1)
            {
                label12.Text = Rez2.ToString(); ;
                label12.Show();

                pictureBox48.Image = imageList1.Images[Number7 - 1];
                pictureBox48.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox47.Image = imageList1.Images[Number8 - 1];
                pictureBox47.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox46.Image = imageList1.Images[Number9 - 1];
                pictureBox46.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox45.Image = imageList1.Images[Number10 - 1];
                pictureBox45.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox44.Image = imageList1.Images[Number11 - 1];
                pictureBox44.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox43.Image = imageList1.Images[Number12 - 1];
                pictureBox43.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (a == 2)
            {
                label11.Text = Rez2.ToString();
                label11.Show();

                pictureBox42.Image = imageList1.Images[Number7 - 1];
                pictureBox42.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox41.Image = imageList1.Images[Number8 - 1];
                pictureBox41.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox40.Image = imageList1.Images[Number9 - 1];
                pictureBox40.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox39.Image = imageList1.Images[Number10 - 1];
                pictureBox39.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox38.Image = imageList1.Images[Number11 - 1];
                pictureBox38.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox37.Image = imageList1.Images[Number12 - 1];
                pictureBox37.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (a == 3)
            {
                label4.Text = Rez2.ToString();
                label4.Show();

                pictureBox36.Image = imageList1.Images[Number7 - 1];
                pictureBox36.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox35.Image = imageList1.Images[Number8 - 1];
                pictureBox35.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox34.Image = imageList1.Images[Number9 - 1];
                pictureBox34.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox33.Image = imageList1.Images[Number10 - 1];
                pictureBox33.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox32.Image = imageList1.Images[Number11 - 1];
                pictureBox32.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox31.Image = imageList1.Images[Number12 - 1];
                pictureBox31.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (a >= 3)
            {
                label3.Show();
                if ((a == i)) 
                {
                    int r1 = Convert.ToInt32(label5.Text);
                    int r2 = Convert.ToInt32(label7.Text);
                    if (r1 > r2) { label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString(); }
                    else if (r2 > r1) { label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString(); }
                    if (brojac == BrojRundi)
                    {
                        int w1 = Convert.ToInt32(label1.Text);
                        int w2 = Convert.ToInt32(label6.Text);
                        if (w1 > w2)
                        {
                            Form4 fr4 = new Form4();
                            Win = 1;
                            this.Hide();
                            fr4.Show();
                        }
                        else if (w2 > w1)
                        {
                            Form4 fr4 = new Form4();
                            Win = 2;
                            this.Hide();
                            fr4.Show();
                        }
                        else if (w1 == w2)
                        {
                            if (BrojRundi == 2) { BrojRundi = 3; }
                            if (BrojRundi == 1) { BrojRundi = 2; }
                            button5.Show();
                        }

                    }
                    else { button5.Show(); }

                    

                    brojac++;
                }
                
            }
            button3.Hide();
            button4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reset();
            button5.Hide();


            
        }


        private void Reset()
        {
            label5.Text = "0";
            label7.Text = "0";
            pictureBox1.Image = null;
            pictureBox7.Image = null;
            pictureBox2.Image = null;
            pictureBox8.Image = null;
            pictureBox3.Image = null;
            pictureBox9.Image = null;
            pictureBox4.Image = null;
            pictureBox10.Image = null;
            pictureBox5.Image = null;
            pictureBox11.Image = null;
            pictureBox6.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;
            pictureBox33.Image = null;
            pictureBox34.Image = null;
            pictureBox35.Image = null;
            pictureBox36.Image = null;
            pictureBox37.Image = null;
            pictureBox38.Image = null;
            pictureBox39.Image = null;
            pictureBox40.Image = null;
            pictureBox41.Image = null;
            pictureBox42.Image = null;
            pictureBox43.Image = null;
            pictureBox44.Image = null;
            pictureBox45.Image = null;
            pictureBox46.Image = null;
            pictureBox47.Image = null;
            pictureBox48.Image = null;
            label8.Text = "";
            label8.Hide();
            label9.Text = "";
            label9.Hide();
            label10.Text = "";
            label10.Hide();
            label12.Text = "";
            label12.Hide();
            label11.Text = "";
            label11.Hide();
            label4.Text = "";
            label4.Hide();
            a = 0;
            i = 0;
            UkRez1 = 0;
            UkRez2 = 0;
            label2.Hide();
            label3.Hide();
            

        }
      

        
    }
}
