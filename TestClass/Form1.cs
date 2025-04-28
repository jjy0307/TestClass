using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            byte byteNum = 10;
            short shortNum = 10;
            int intNum = 100;
            float floatNum = 10.5f;
            double doubleNum = 10.55d;
            decimal decimalNum = 10.555m;


            testBox_print.Text += byteNum.GetType() + " byteNum: " + byteNum.ToString() + "\r\n";
            testBox_print.Text += shortNum.GetType() + " shortNum: " + shortNum.ToString() + "\r\n";
            testBox_print.Text += intNum.GetType() + " intNum: " + intNum.ToString() + "\r\n";
            testBox_print.Text += floatNum.GetType() + " floatNum: " + floatNum.ToString() + "\r\n";
            testBox_print.Text += doubleNum.GetType() + " doubleNum: " + doubleNum.ToString() + "\r\n";
            testBox_print.Text += decimalNum.GetType() + " decimalNum: " + decimalNum.ToString() + "\r\n";
        }
    }
}
