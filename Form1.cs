using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private int NAEQ6(string letter) // this function only takes a letter and outputs a number.
        {

            switch(letter)
            {
                case "A": return 1;
                case "L": return 2;
                case "W": return 3;
                case "H": return 4;
                case "S": return 5;
                case "D": return 6;
                case "O": return 7;
                case "Z": return 8;
                case "K": return 9;
                case "V": return 10;
                case "G": return 11;
                case "R": return 12;
                case "C": return 13;
                case "N": return 14;
                case "Y": return 15;
                case "J": return 16;
                case "U": return 17;
                case "F": return 18;
                case "Q": return 19;
                case "B": return 20;
                case "M": return 21;
                case "X": return 22;
                case "I": return 23;
                case "T": return 24;
                case "E": return 25;
                case "P": return 26;
                default: return 0;
            }
        }

        private int mispar_gadol(string letter) // this only takes a "letter" and outputs a number. (dipthongs are letters)
        {

            switch (letter)
            {
                case "A": return 1;
                case "א": return 1;
                case "E": return 1;

                case "B": return 2;
                case "ב": return 2;

                case "G": return 3;
                case "ג": return 3;

                case "D": return 4;
                case "ד": return 4;

                case "H": return 5;
                case "ה": return 5;

                case "U": return 6;
                case "ו": return 6;
                case "V": return 6;

                case "Z": return 7;
                case "ז": return 7;

                case "CH": return 8;
                case "ח": return 8;

                case "T": return 9;
                case "ט": return 9;

                case "J": return 10;
                case "I": return 10;
                case "Y": return 10;
                case "י": return 10;

                case "W": return 12; // V == 6: return W == VV: return 6 + 6 == 12

                case "K": return 20;
                case "כ": return 20;

                case "L": return 30;
                case "ל": return 30;

                case "M": return 40;
                case "מ": return 40;

                case "N": return 50;
                case "נ": return 50;

                case "S": return 60;
                case "ס": return 60;

                case "A'A": return 70;
                case "ע": return 70;

                case "P": return 80;
                case "פ": return 80;

                case "TZ": return 90;
                case "צ": return 90;

                case "Q": return 100;
                case "ק": return 100;

                case "R": return 200;
                case "ר": return 200;

                case "SH": return 300;
                case "ש": return 300;

                case "TH": return 400;
                case "ת": return 400;

                // below are "finals" represented by concatenating a period to the input of this function
                case "K.": return 500;
                case "ך": return 500;

                case "M.": return 600;
                case "ם": return 600;

                case "N.": return 700;
                case "ן": return 700;

                case "P.": return 800;
                case "ף": return 800;

                case "TZ.": return 900;
                case "ץ": return 900;

                default: return 0;
            }
        }



        private int isopsephy(string letter) // this only takes a "letter" and outputs a number. (dipthongs are letters)
        {
            switch (letter)
            {
                case "A": return 1;
                case "Α": return 1; //alpha
                    
                case "B": return 2;
                case "Β": return 2; //beta

                case "G": return 3;
                case "Γ": return 3;

                case "D": return 4;
                case "Δ": return 4;

                case "E": return 5;
                case "Ε": return 5; //epsilon

                case "W": return 6;
                case "Ϝ": return 6; //digamma

                case "Z": return 7;
                case "Ζ": return 7; //zeta

                case "H": return 8;
                case "Η": return 8; //eta

                case "TH": return 9;
                case "Θ": return 9;

                case "I": return 10;
                case "Ι": return 10; //iota

                case "K": return 20;
                case "Κ": return 20; //kappa

                case "L": return 30;
                case "Λ": return 30;

                case "M": return 40;
                case "Μ": return 40; //mu

                case "N": return 50;
                case "Ν": return 50; //nu

                case "X": return 60;
                case "Ξ": return 60; 

                case "O": return 70;
                case "Ο": return 70;//omnicron

                case "P": return 80;
                case "Π": return 80;

                case "Q": return 90;
                case "Ϙ": return 90;

                case "R": return 100;
                case "Ρ": return 100; //rho

                case "S": return 200;
                case "Σ": return 200;

                case "T": return 300;
                case "Τ": return 300; //this is the greek letter

                case "U": return 400;
                case "Υ": return 400; //upsilon
                case "Y": return 400;

                case "PH": return 500;
                case "Φ": return 500;

                case "CH": return 600;
                case "Χ": return 600; //chi

                case "PS": return 700;
                case "Ψ": return 700;

                case "@": return 800; // OMEGA stand-in for keyboards that do not have it
                case "Ω": return 800;

                case "TS": return 900;
                case "ϡ": return 900;
                default: return 0;
            }
        }

        private int abjad(string letter)
        {
            switch(letter)
            {
                case "ا": return 1;   //name : alif
                case "ب": return 2;   //name : bāʼ
                case "پ": return 2;   //name : pe ** persian letter
                case "ج": return 3;   //name : jīm
                case "چ": return 3;   //name : če or che ** persian letter
                case "د": return 4;   //name : dāl
                case "ه": return 5;   //name : hāʼ
                case "و": return 6;   //name : wāw
                case "ز": return 7;   //name : zayn/zāy
                case "ژ": return 7;   //name : že or zhe ** persian letter
                case "ح": return 8;   //name : ḥāʼ
                case "ط": return 9;   //name : ṭāʼ
                case "ي": return 10;  //name : yāʼ
                case "ك": return 20;  //name : kāf
                case "گ": return 20;  //name : gâf ** persian letter
                case "ل": return 30;  //name : lām
                case "م": return 40;  //name : mīm
                case "ن": return 50;  //name : nūn
                case "س": return 60;  //name : sīn
                case "ع": return 70;  //name : ʻayn
                case "ف": return 80;  //name : fāʼ
                case "ص": return 90;  //name : ṣād
                case "ق": return 100; //name : qāf
                case "ر": return 200; //name : rāʼ
                case "ش": return 300; //name : shīn
                case "ت": return 400; //name : tāʼ
                case "ث": return 500; //name : thāʼ
                case "خ": return 600; //name : khāʼ
                case "ذ": return 700; //name : dhāl
                case "ض": return 800; //name : ḍād
                case "ظ": return 900; //name : ẓāʼ
                case "غ": return 1000;//name : ghayn
                default: return 0; 
            }
        }

        private int mispar_milui(string letter) // full name value. Note: There is more than one way to spell each letter and the gematria calculator uses the most common spellings.
        {
            switch(letter)
            {
                case "A": return 111;
                case "א": return 111;
                case "E": return 111;

                case "B": return 412;
                case "ב": return 412;

                case "G": return 73;
                case "ג": return 73;

                case "D": return 434;
                case "ד": return 434;

                case "H": return 6;
                case "ה": return 6;

                case "U": return 22;
                case "ו": return 22;
                case "V": return 22;

                case "Z": return 77;
                case "ז": return 77;

                case "CH": return 418;
                case "ח": return 418;

                case "T": return 419;
                case "ט": return 419;

                case "J": return 20;
                case "I": return 20;
                case "Y": return 20;
                case "י": return 20;

                case "W": return 44; // V == 6: return W == VV: return 6 + 6 == 12

                case "K": return 100;
                case "כ": return 100;

                case "L": return 74;
                case "ל": return 74;

                case "M": return 80;
                case "מ": return 80;

                case "N": return 106;
                case "נ": return 106;

                case "S": return 120;
                case "ס": return 120;

                case "A'A": return 130;
                case "ע": return 130;

                case "P": return 81;
                case "פ": return 81;

                case "TZ": return 104;
                case "צ": return 104;

                case "Q": return 186;
                case "ק": return 186;

                case "R": return 510;
                case "ר": return 510;

                case "SH": return 360;
                case "ש": return 360;

                case "TH": return 406;
                case "ת": return 406;

                default: return 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            populateCipher();
        }

        /*
         * this function determines which cipher to use. It should be called whenever the page needs to be refreshed.
         * It populates the labels with the strings and numbers associated with the corresponding ciphers
         * 
         * 0 = NAEQ6
         * 1 = mispar gadol
         * 2 = Isopsephy
         * 3 = Abjad
         * 4 = mispar miluil
         * 
         */
        private void populateCipher() 
        {
            char[] cipher_letters = textBox1.Text.ToUpper().ToCharArray(); // Turns the text in the textbox into an array of capital characters
            string[] cipher_dipthongs = null;
            Array.Resize(ref cipher_dipthongs, cipher_letters.Length);

            for (int i = 0; i < cipher_letters.Length; i++)
            {
                cipher_dipthongs[i] = new string(cipher_letters[i], 1);
            }

            List<string> dipthongList = new List<string>();


            switch (comboBox1.SelectedIndex)
            {
                case 2:
                    dipthongList.Add("TH");
                    dipthongList.Add("PH");
                    dipthongList.Add("CH");
                    dipthongList.Add("PS");
                    dipthongList.Add("TS");

                    cipher_dipthongs = dipthong_join(cipher_dipthongs, dipthongList);
                    break;
                case 4:
                case 1:
                    dipthongList.Add("CH");
                    dipthongList.Add("A'A");
                    dipthongList.Add("TZ");
                    dipthongList.Add("TH");

                    cipher_dipthongs = dipthong_join(cipher_dipthongs, dipthongList);
                    break;
                case 0:
                default:
                    break;
            }



            label1.Text = string.Join(" + ", cipher_dipthongs.Where(s => !string.IsNullOrEmpty(s))); // Prints the input as individual "letters"
            
            int[] cipher_numbers = cipher_convert(cipher_dipthongs, comboBox1.SelectedIndex); // this is where the cipher is converted from letters to numbers
            string[] cipher_numbers_string = null;
            Array.Resize(ref cipher_numbers_string, cipher_numbers.Length);
            for (int i = 0; i < cipher_numbers.Length; i++)
            {
                cipher_numbers_string[i] = cipher_numbers[i].ToString();
            }
            label2.Text = string.Join(" + ", cipher_numbers_string.Where(s => !string.IsNullOrEmpty(s)));

            label3.Text = cipher_numbers.Sum().ToString();
        }

        delegate int ConvertMethod(string inString);
        // takes a string array of letters and/or dipthongs and returns an int array of their correspoding values.
        private int[] cipher_convert(string[] cipher_letters, int cipher_control)
        {
            int[] cipher_numbers = null;
            Array.Resize(ref cipher_numbers, cipher_letters.Length);
            ConvertMethod cipher = null;
            switch(cipher_control)
            {
                case 4: cipher = mispar_milui;  break;
                case 3: cipher = abjad;         break;
                case 2: cipher = isopsephy;     break;
                case 1: cipher = mispar_gadol;  break;
                case 0: // NAEQ6
                default: cipher = NAEQ6;        break;
            }

            if (cipher_control == 1 && cipher_letters.Length >= 1)
            {
                int letter = cipher_letters.Length - 1;
                switch (cipher_letters[letter]) // the below is for final letters only in mispar_gadol
                {
                    case "K": cipher_letters[letter] = "K."; break;
                    case "M": cipher_letters[letter] = "M."; break;
                    case "N": cipher_letters[letter] = "N."; break;
                    case "P": cipher_letters[letter] = "P."; break;
                    default: break;
                }
                if (cipher_letters.Length >= 2 && cipher_letters[letter - 1] == "TZ")
                {
                    cipher_letters[letter - 1] = "TZ."; // for final TZ in mispar_gadol
                }
            }

            for (int letter = 0; letter < cipher_letters.Length; letter++)
            {
                cipher_numbers[letter] = cipher(cipher_letters[letter]);
            }

            return cipher_numbers;
        }

        // takes a string array of letters and a list of dipthongs and attepts to join the elements in the string array to match the dipthongs. returns the edited array
        private string[] dipthong_join(string[] cipher_letters, List<string> dipthong_list) // WARNING: only supports 2 or 3 letter dipthongs
        {

            foreach (string dipthong in dipthong_list)
            {
                for (int letter = 0; letter <= cipher_letters.Length - dipthong.Length; letter++) // only goes to the last letter that could possibly be in a dipthong
                {
                    if (!string.IsNullOrEmpty(cipher_letters[letter]) && !string.IsNullOrEmpty(cipher_letters[letter + 1]) && cipher_letters[letter][0] == dipthong[0] && cipher_letters[letter + 1][0] == dipthong[1]) //checks if first two letters match
                    {
                        if (dipthong.Length == 3 && !string.IsNullOrEmpty(cipher_letters[letter+ 2]) && cipher_letters[letter + 2][0] == dipthong[2]) //checks for 3 letter dipthongs
                        {
                            cipher_letters[letter] = cipher_letters[letter] + cipher_letters[letter + 1] + cipher_letters[letter + 2];
                            cipher_letters[letter + 1] = String.Empty;
                            cipher_letters[letter + 2] = String.Empty;
                        }
                        else
                        {
                            cipher_letters[letter] = cipher_letters[letter] + cipher_letters[letter + 1];
                            cipher_letters[letter + 1] = String.Empty;
                        }
                    }
                }
            }


            return cipher_letters;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateCipher();
        }
    }
}
