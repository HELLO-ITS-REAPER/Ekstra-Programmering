using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Password_Strengh_Indicator
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


        private void CheckPassword_Click(object sender, RoutedEventArgs e)
        {
            string total = Password.Password;
            char currentCharacter;
            int passwordLength = Password.Password.Length;


            bool isNum = false;
            bool isLet = false;
            bool isSymb = false;
            bool isMin = false;

            if (passwordLength >= 8)
            {
                isMin = true;
            }

            for (int i = 0; i < Password.Password.Length; i++)
            {
                currentCharacter = Password.Password[i];


                if (!char.IsLetterOrDigit(currentCharacter))
                {
                    isSymb = true;
                }
                if (char.IsDigit(currentCharacter))
                {
                    isNum = true;
                }
                if (char.IsLetter(currentCharacter))
                {
                    isLet = true;
                }
                
            }

            if (isSymb && isLet && isNum && isMin)
            {
                Indicator.Text = "Very strong";
            }
            else if (isLet && isNum && isMin)
            {
                Indicator.Text = "Strong";
            }
            else if (isLet)
            {
                Indicator.Text = "Weak";
            }
            else if (isNum)
            {
                Indicator.Text = "Very weak";
            }
            else
            {
                Indicator.Text = "Error";
            }
        }
    }
}
