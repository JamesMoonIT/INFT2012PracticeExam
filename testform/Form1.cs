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
            Student anthony = new Student(studentname);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string phoneNo = txbxNumber.Text;
            if (phoneNo.Length == 10)
            {
                if (phoneNo.Substring(0, 2) == "02" || phoneNo.Substring(0, 2) == "04" || phoneNo.Substring(0, 2) == "03" || phoneNo.Substring(0, 2) == "07" || phoneNo.Substring(0, 2) == "08")
                {
                    lblResult.Text = "Valid";
                }
                else
                {
                    lblResult.Text = "Not Valid";
                }
            }
            else if (phoneNo.Length == 11)
            {
                if (phoneNo.Substring(0, 2) == "61")
                {
                    lblResult.Text = "Valid";
                }
                else
                {
                    lblResult.Text = "Not Valid";
                }
            }
            else if (phoneNo.Length == 8)
            {
                lblResult.Text = "Valid";
            }
            else
            {
                lblResult.Text = "Not Valid";
            }
        }

        private void switchvalues()
        {
            int sOne = 0, sTwo = 1, sExtra;
            sExtra = sOne;
            sTwo = sOne;
            sOne = sExtra;
            MessageBox.Show("sOne =");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double price = 0;
            int basePrice = Convert.ToInt32(txbxBasePrice.Text);
            int bedrooms = Convert.ToInt32(txbxBedrooms.Text);
            bool difficult = Convert.ToBoolean(cbxDifficult.Checked);
            if (basePrice < 0)
            {
                basePrice *= -1;
            }
            if (bedrooms < 0)
            {
                bedrooms *= -1;
            }
            if (bedrooms == 1)
            {
                bedrooms = -10000;
            }
            else if (bedrooms == 2)
            {
                bedrooms = 0;
            }
            else
            {
                bedrooms = (bedrooms - 2) * 10000;
            }
            price = basePrice + bedrooms;
            if (difficult)
            {
                price *= 1.1;
            }
            txbxResult.Text = String.Format("{0:c}", price);
        }

        private void LargestCases(int Month)
        {
            int[,] iCases = new int[32, 13];
            int largestDay = 0, totalCasesforMonth = 0;
            for (int day = 1; day <= 32; day++)
            {
                totalCasesforMonth = iCases[day, Month];   // Number of cases in a month
                if (iCases[day,Month] > largestDay)
                {
                    largestDay = day;   // The Day of the Month that had the greatest number of cases
                }
            }
        }

        private string RollDice()
        {
            Random rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int dice3 = rand.Next(1, 7);
            int dice4 = rand.Next(1, 7);
            int dice5 = rand.Next(1, 7);
            int result = dice1 + dice2 + dice3 + dice4 + dice5;
            return Convert.ToString(result) + ": " + Convert.ToString(dice1) + " " + Convert.ToString(dice2) + " " + Convert.ToString(dice3) + " " + Convert.ToString(dice4) + " " + Convert.ToString(dice5);
        }

        private void PlayGame()
        {
            string result = RollDice();
            int rollsum = 0;
            if (result.Length == 12)
            {
                rollsum = Convert.ToInt32(result.Substring(0, 1));
            }
            else
            {
                rollsum = Convert.ToInt32(result.Substring(0, 2));
            }
            if (rollsum < 10 || rollsum > 26)
            {
                result += " - bonus 20 points!";
            }
            tbxMessage.Text += result + System.Environment.NewLine;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        private void CreateEmployees()
        {
            Employee employee1 = new Employee("Simon");
            Employee employee2 = new Employee("James", "Student", 21);
        }
    }
}
