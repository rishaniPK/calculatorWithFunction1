using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorWithFunction1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Add function to add 2 numbers. This function accept two string type parameters and string type return value
        static string Add(string firstNumber, string SecondNumber)
        {
        int first_number = int.Parse(firstNumber);
        int second_number = int.Parse(SecondNumber);
        int result = first_number + second_number;
        return result.ToString();
        }

        // Sub function to perform subtraction operation. This function accept two string type parameters and string type return value
        static string Sub(string firstNumber, string SecondNumber)
        {
            int first_number = int.Parse(firstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_number - second_number;
            return result.ToString();
        }
        // Mult function to perform multiplication operation. This function accept two string type parameters and string type return value
        static string Mul(string firstNumber, string SecondNumber)
        {
            int first_number = int.Parse(firstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_number * second_number;
            return result.ToString();
        }
        // Div function to perform Division operation. This function accept two string type parameters and string type return value
        static string Div(string firstNumber, string SecondNumber)
        {
            int first_number = int.Parse(firstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_number / second_number;
            return result.ToString();
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
          txt_result.Text = Add(txt_num1.Text, txt_num2.Text);
        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            txt_result.Text = Sub(txt_num1.Text, txt_num2.Text);
        }

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            txt_result.Text = Mul(txt_num1.Text, txt_num2.Text);
        }

        private void Btn_divi_Click(object sender, EventArgs e)
        {
            txt_result.Text = Div(txt_num1.Text, txt_num2.Text);
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }

}