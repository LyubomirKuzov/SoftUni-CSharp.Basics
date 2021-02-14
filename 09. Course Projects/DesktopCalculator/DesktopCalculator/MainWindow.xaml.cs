using System;
using System.Collections.Generic;
using System.Data;
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

namespace DesktopCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private bool EqualsClicked = false;



        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResult.Text.Length > 0)
            {
                TextBoxResult.Text = TextBoxResult.Text.Substring(0, TextBoxResult.Text.Length - 1);
            }
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '1';
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '2';
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '3';
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '4';
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '5';
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '6';
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '7';
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '8';
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '9';
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            TextBoxResult.Text += '0';
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = string.Empty;
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxResult.Text.Length > 0)
            {
                char[] temp = new char[] { '(', ')', '.', '+', '-', '*', '/' };

                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '.';
                }
            }
        }

        private void ButtonLeftBracket_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            char[] temp = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '(';
                }
            }

            else
            {
                TextBoxResult.Text += '(';
            }
        }

        private void ButtonRightBracket_Click(object sender, RoutedEventArgs e)
        {
            char[] temp = new char[] { '.', '*', '/', '+', '-', '(' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += ')';
                }
            }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            char[] temp = new char[] { '.', '*', '/', '+', '-', '(' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '+';
                }
            }
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            EmptyResultTextBox();

            char[] temp = new char[] { '.', '*', '/', '+', '-' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '-';
                }
            }

            else
            {
                TextBoxResult.Text += '-';
            }
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            char[] temp = new char[] { '.', '*', '/', '+', '-', '(' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '*';
                }
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            char[] temp = new char[] { '.', '*', '/', '+', '-', '(' };

            if (TextBoxResult.Text.Length > 0)
            {
                if (!temp.Any(e => e == TextBoxResult.Text[TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text += '/';
                }
            }
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal result = Convert.ToDecimal(new DataTable().Compute(TextBoxResult.Text, null));
                TextBoxResult.Text = result.ToString();
            }

            catch (Exception)
            {
                TextBoxResult.Text = "Error!";
            }

            EqualsClicked = true;
        }

        private void EmptyResultTextBox()
        {
            if (this.EqualsClicked)
            {
                this.TextBoxResult.Text = string.Empty;
                this.EqualsClicked = false;
            }
        }
    }
}
