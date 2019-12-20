using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float num01 = 0;
        float num02 = 0;
        string operation = "";
        

        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 1;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 1;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 2;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 2;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 3;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 3;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 4;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 4;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 5;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 5;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 6;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 6;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 7;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 7;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 8;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 8;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10) + 9;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10) + 9;
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 * 10);
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 * 10);
                txtDisplay.Text = num02.ToString();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void Divided_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (num01 + num02).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (num01 - num02).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (num01 * num02).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (num01 / num02).ToString();
                    break;


            }
            num01 = 0;
            num02 = 0;
            operation = "";            
        }

        private void ClearEntries_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num01 = 0;
            }
            else
            {
                num02 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            num01 = 0;
            num02 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void BackSlash_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 = (num01 / 10);
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 = (num02 / 10);
                txtDisplay.Text = num02.ToString();
            }
        }

        private void PositiveandNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num01 += -1;
                txtDisplay.Text = num01.ToString();
            }
            else
            {
                num02 += -1;
                txtDisplay.Text = num02.ToString();
            }
        }
    }
}
