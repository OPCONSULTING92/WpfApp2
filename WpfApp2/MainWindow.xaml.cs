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
//https://www.c-sharpcorner.com/UploadFile/manas1/json-serialization-and-deserialization-using-json-net-librar/
namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (IndexOutOfRangeException ex)  // CS0168
            {
                Console.WriteLine(ex.Message);
                // Set IndexOutOfRangeException to the new exception's InnerException.
                throw new ArgumentOutOfRangeException("index parameter is out of range.", ex);
            }
            catch (Exception exc)
            {
                
                tbResult.Text = exc.Message;
            }

        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (tbCalcul.Text.Contains("+"))
            {
                iOp = tbCalcul.Text.IndexOf("+");
            }
            else if (tbCalcul.Text.Contains("-"))
            {
                iOp = tbCalcul.Text.IndexOf("-");
            }
            else if (tbCalcul.Text.Contains("*"))
            {
                iOp = tbCalcul.Text.IndexOf("*");
            }
            else if (tbCalcul.Text.Contains("/"))
            {
                iOp = tbCalcul.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = tbCalcul.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tbCalcul.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tbCalcul.Text.Substring(iOp + 1, tbCalcul.Text.Length - iOp - 1));
            switch (op)
            {
                case "+":
                    tbResult.Text += "=" + (op1 + op2);
                    break;
                case "-":
                    tbResult.Text += "=" + (op1 - op2);
                    break;
                case "*":
                    tbResult.Text += "=" + (op1 * op2);
                    break;
                //case "/":
                //    tbResult.Text += "=" + (op1 / op2);
                //    break;
                default:
                    tbResult.Text = "=" + (op1 / op2);
                    break;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var stB = new StringBuilder();
            for (int i = 0; i < 100; i+=20)
            {
                // Part 2: append to StringBuilder.
                stB.Append(i).Append(" ");
            }
            tbStrBuilder.Text = stB.ToString();

        }
    }
}
