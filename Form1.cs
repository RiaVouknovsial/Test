using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Test
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer;
        public Form1()
        {
            InitializeComponent();
             answer = new int[15];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._1_DNA);
            pictureBox1.BackgroundImage = bmp;
        }
        public void show (int n)
        {
            int n1 = n + 1;
            label1.Text = "Вопрос №" + n1;
            switch(n)
            {
                
                case 0:
                 pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._1_DNA);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._2_Earth);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._3_Baptism_of_Rus);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._4_Cell);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._5_Plant_family);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._6_Ocean);
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._7_Smyle);
                    break;
                case 7:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._8_chemistry);
                    break;
                case 8:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._9_history);
                    break;
                case 9:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._10_moon);
                    break;
                case 10:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._11_math);
                    break;
                case 11:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._12_blood);
                    break;
                case 12:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._13_colors);
                    break;
                case 13:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._14_war);
                    break;
                case 14:
                    pictureBox1.BackgroundImage = new Bitmap(WindowsFormsApp1_Test.Properties.Resources._15_human);
                    break;
            }
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 2:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    radioButton4.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    break;
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (n >14) n = 14;
            show(n);
        }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 4;
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 0;
            if (answer[0] == 3)
                correct ++;
            if (answer[1] == 2)
                correct++;
            if (answer[2] == 1)
                correct++;
            if (answer[3] == 1)
                correct++;
            if (answer[4] == 2)
                correct++;
            if (answer[5] == 3)
                correct++;
            if (answer[6] == 4)
                correct++;
            if (answer[7] == 4)
                correct++;
            if (answer[8] == 3)
                correct++;
            if (answer[9] == 4)
                correct++;
            if (answer[10] == 1)
                correct++;
            if (answer[11] == 1)
                correct++;
            if (answer[12] == 2)
                correct++;
            if (answer[13] == 2)
                correct++;
            if (answer[14] == 3)
                correct++;
            int procent = correct*100 / 15;
            
            string message = "Вы не прошли тест";
            if (procent >= 75) message = "Вы прошли тест";
            MessageBox.Show("Вы ответили на " + procent + " процентов вопросов верно. " + message);
        }
    }
}
