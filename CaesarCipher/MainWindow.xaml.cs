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

namespace CaesarCipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtForEncryption.Text = string.Empty;
            txtForEncryption.Text = "Wprowadz tekst do zaszyfrowania";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] alphabet = new char[] { 'A','Ą','B','C','Ć','D','E','Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W','X','Y','Z','Ź','Ż' };
            afterEncription.Text = string.Empty;
            int key = Int32.Parse(encryptionKey.Text);

            
            for (int i = 0; i < txtForEncryption.Text.Length; i++)
            {
                char letter = txtForEncryption.Text[i];
                letter = (char)(letter + key);

                
            
                if (letter > 'z')
                    letter = (char)(letter - 26);
                else if (letter < 'a')
                    letter = (char)(letter + 26);

                afterEncription.Text += letter;
            }   
            
        }

        private void encryptionKey_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            afterDecryption.Text = string.Empty;
            int DKey = Int32.Parse(decryptionKey.Text);

            for (int i = 0; i < txtForDecryption.Text.Length; i++)
            {
                char TmpLetter = txtForDecryption.Text[i];
                TmpLetter = (char)(TmpLetter - DKey);

                if (TmpLetter > 'z')
                    TmpLetter = (char)(TmpLetter - 26);
                else if (TmpLetter < 'a')
                    TmpLetter = (char)(TmpLetter + 26);

                afterDecryption.Text += TmpLetter;
            }
        }
    }
}
