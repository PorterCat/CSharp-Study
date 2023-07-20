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
using System.Xml;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string EquationText
        {
            get { return text.Text; }
            set 
            {
                text.Text = value; 
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in NumberButtons.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += NumberButtonClick;
                }
            }
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            EquationText = string.Empty;
        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            EquationText += button.Content.ToString();
        }

        private void EraseButtonClick(object sender, RoutedEventArgs e)
        {
            if(EquationText.Length - 1 >= 0)
            {
                EquationText = EquationText.Remove(EquationText.Length - 1);
            }
        }

        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {
            EquationText = Equation.Solve(EquationText).ToString();
            /*try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}

