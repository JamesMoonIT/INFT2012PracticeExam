using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testform
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void mystery(string sOne, ref int iTwo, out int iThree)
        {
            string sSample;
            string sUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string sLowercase = "abcdefghijklmnopqrstuvwxyz";
            iTwo = 0;
            iThree = 0;
            while (sOne != "")
            {
                sSample = sOne.Substring(0, 1);
                sOne = sOne.Substring(1);
                if (sUppercase.IndexOf(sSample) >= 0)
                    iTwo = iTwo + 2;
                else if (sLowercase.IndexOf(sSample) >= 0)
                    iThree = iThree + 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = 0; int i2;
            string sMessage = "Kiss Me Quick!";
            mystery(sMessage, ref i1, out i2);
            MessageBox.Show(string.Format(sMessage + " {0:d} {1:d}", i1, i2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((850 > 1000 && (18 > 20 || 32 > 30) && 215 > 200) == false)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int earliertime = Convert.ToInt32(textBox1.Text);
            int latertime = Convert.ToInt32(textBox2.Text);
            int result = 0;
            if (radioButton2.Checked)
            {
                earliertime += 12;
            }
            if (radioButton4.Checked)
            {
                latertime += 12;
            }
            if (latertime > earliertime)
            {
                result = latertime - earliertime;
            }
            else
            {
                result = earliertime - latertime;
            }
            int newresult = 24 - result;
            textBox3.Text = Convert.ToString(newresult);
        }

        private double halfSum(double a, double b)
        {
            double halfSum = 0;
            return halfSum = a + b / 2;
        }

        private void runmethod_Click(object sender, EventArgs e)
        {
            halfSum(Convert.ToInt32(a.Text), Convert.ToInt32(b.Text));
        }

        private double mystery(string[] sSurname)
        {
            int iNum = 0;
            for (int i = 0; i < sSurname.Length; i++)
            {
                if (sSurname[i].IndexOf("-") > -1) iNum = iNum + 1;
            }
            return Convert.ToDouble(iNum) / sSurname.Length;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string studentname = txbxStudentName.Text;
            Student stu = new Student(studentname);
        }
    }
}
