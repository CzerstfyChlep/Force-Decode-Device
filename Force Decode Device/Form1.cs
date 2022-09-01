using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Force_Decode_Device
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();            
        }
        public string[] Alphabet = { "A","Ą", "B", "C","Ć", "D", "E","Ę", "F", "G", "H", "I", "J", "K", "L","Ł", "M", "N","Ń","O","Ó","P", "Q", "R", "S", "Ś","T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]" , "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t","u","v","w","x","y","z","ż","ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã","Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};
        public string[] CodeAlphabet = { "A", "Ą", "B", "C", "Ć", "D", "E", "Ę", "F", "G", "H", "I", "J", "K", "L", "Ł", "M", "N", "Ń", "O", "Ó", "P", "Q", "R", "S", "Ś", "T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]", "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t", "u", "v", "w", "x", "y", "z", "ż", "ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã" ,"Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};
        public int LetterTry = 0;
        public int SpinsTry = 1;
        public bool Reverse1 = false;
        public void MoveLetters(int RotationNumber = 1)
        {
            for (int N = RotationNumber; N != 0; N--)
            {
                Queue CodeAlphabetQ = new Queue(CodeAlphabet);
                CodeAlphabetQ.Enqueue(CodeAlphabetQ.Dequeue());
                CodeAlphabetQ.CopyTo(CodeAlphabet, 0);
            }
        }
        public void SetCodeAlphabet()
        {
            if (Reverse1 == false)
            {
                Alphabet.CopyTo(CodeAlphabet, 0);
                int Position = LetterTry;
                for (; Position > 0; Position--)
                {
                    MoveLetters();
                }
            }
            else
            {
                Alphabet.CopyTo(CodeAlphabet, 0);
                Array.Reverse(CodeAlphabet);
                int Position = LetterTry;
                for (; Position > 0; Position--)
                {
                    MoveLetters();
                }
            }
        }
        private void ForceButton_Click(object sender, EventArgs e)
        {
            Loop:
            SetCodeAlphabet();
            string Text = InputBox.Text;
            char[] Arr = Text.ToCharArray();
            Text = "";
            foreach (char c in Arr)
            {
                MoveLetters(SpinsTry);       
                try
                {
                    int Index = Array.IndexOf(CodeAlphabet, c.ToString());
                    Text += Alphabet.ElementAt(Index);
                }
                catch
                {
                }

            }
            if (LetterTry < 164)
            {
                LetterTry++;
            }
            else
            {
                LetterTry = 0;
                if (SpinsTry < 164)
                {
                    SpinsTry++;
                }
                else
                {
                    SpinsTry = 1;
                    Reverse1 = true;
                }
            }
            if (checkBox1.Checked == true)
            {
                if (Text.Contains(" ") == true && (Text.Contains("ª") == false && Text.Contains("ª") == false && Text.Contains("¬") == false && Text.Contains("À") == false && Text.Contains("Á") == false && Text.Contains("Ã") == false && Text.Contains("Ä") == false && Text.Contains("Æ") == false && Text.Contains("Ç") == false && Text.Contains("È") == false && Text.Contains("É") == false && Text.Contains("Ê") == false && Text.Contains("Ë") == false && Text.Contains("Ì") == false && Text.Contains("Í") == false && Text.Contains("Ð") == false && Text.Contains("Ñ") == false && Text.Contains("Ò") == false && Text.Contains("Ô") == false && Text.Contains("Õ") == false && Text.Contains("Ö") == false && Text.Contains("Ø") == false && Text.Contains("Ù") == false && Text.Contains("Ú") == false && Text.Contains("Û") == false && Text.Contains("Ü") == false && Text.Contains("½") == false && Text.Contains("¼") == false && Text.Contains("³") == false && Text.Contains("²") == false && Text.Contains("±") == false && Text.Contains("°") == false && Text.Contains("¤") == false && Text.Contains("¨") == false && Text.Contains("{") == false && Text.Contains("}") == false && Text.Contains("|") == false && Text.Contains("©") == false && Text.Contains("_") == false && Text.Contains("#") == false && Text.Contains("^") == false && Text.Contains("~") == false && Text.Contains("`") == false && Text.Contains("\'") == false && Text.Contains("¡") == false && Text.Contains("¢") == false && Text.Contains("¥") == false && Text.Contains("¦") == false && Text.Contains("§") == false && Text.Contains("«") == false && Text.Contains("»") == false && Text.Contains("°") == false && Text.Contains("µ") == false && Text.Contains("¶") == false && Text.Contains("·") == false && Text.Contains("¸") == false && Text.Contains("¹") == false))
                {
                    goto Result;
                }
            }
            else
            {
                if ((Text.Contains("ª") == false && Text.Contains("ª") == false && Text.Contains("¬") == false && Text.Contains("À") == false && Text.Contains("Á") == false && Text.Contains("Ã") == false && Text.Contains("Ä") == false && Text.Contains("Æ") == false && Text.Contains("Ç") == false && Text.Contains("È") == false && Text.Contains("É") == false && Text.Contains("Ê") == false && Text.Contains("Ë") == false && Text.Contains("Ì") == false && Text.Contains("Í") == false && Text.Contains("Ð") == false && Text.Contains("Ñ") == false && Text.Contains("Ò") == false && Text.Contains("Ô") == false && Text.Contains("Õ") == false && Text.Contains("Ö") == false && Text.Contains("Ø") == false && Text.Contains("Ù") == false && Text.Contains("Ú") == false && Text.Contains("Û") == false && Text.Contains("Ü") == false && Text.Contains("½") == false && Text.Contains("¼") == false && Text.Contains("³") == false && Text.Contains("²") == false && Text.Contains("±") == false && Text.Contains("°") == false && Text.Contains("¤") == false && Text.Contains("¨") == false && Text.Contains("{") == false && Text.Contains("}") == false && Text.Contains("|") == false && Text.Contains("©") == false && Text.Contains("_") == false && Text.Contains("#") == false && Text.Contains("^") == false && Text.Contains("~") == false && Text.Contains("`") == false && Text.Contains("\'") == false && Text.Contains("¡") == false && Text.Contains("¢") == false && Text.Contains("¥") == false && Text.Contains("¦") == false && Text.Contains("§") == false && Text.Contains("«") == false && Text.Contains("»") == false && Text.Contains("°") == false && Text.Contains("µ") == false && Text.Contains("¶") == false && Text.Contains("·") == false && Text.Contains("¸") == false && Text.Contains("¹") == false))
                {
                    goto Result;
                }
            }
            goto Loop;
            Result:
            DialogResult result = MessageBox.Show(Text, "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                OutputBox.Text = Text;
                Code.Text = Alphabet.GetValue((LetterTry - 1)) + " " + SpinsTry + " " + Reverse1;
                LetterTry = 0;
                SpinsTry = 0;
                Reverse1 = false;
            }
            else if (result == DialogResult.No)
            {
                goto Loop;
            }
            else
            {
                LetterTry = 0;
                SpinsTry = 0;
                Reverse1 = false;

            }
        }
    }
    
}
//(Text.Contains(" się ") == true || Text.Contains(" i ") == true || Text.Contains(" w ") == true || Text.Contains("nie") == true || Text.Contains("na") == true || Text.Contains(" z ") == true || Text.Contains("do") == true || Text.Contains("to") == true || Text.Contains(" że ") == true || Text.Contains(" a ") == true || Text.Contains(" o ") == true || Text.Contains(" jak ") == true || Text.Contains("ale") == true || Text.Contains("po") == true || Text.Contains("co") == true || Text.Contains("tak") == true || Text.Contains("za") == true || Text.Contains("od") == true || Text.Contains("go") == true || Text.Contains("już") == true || Text.Contains("jego") == true && Text.Contains("jego") == true && Text.Contains("jego") == true && Text.Contains("jego") == true && Text.Contains("jego") == true)  || 