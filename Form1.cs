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

        private int simpleGematria(string letter) // this only takes a "letter" and outputs a number. (dipthongs are letters)
        {

            switch (letter)
            {
                case "A": return 1;
                case "E": return 1;
                case "B": return 2;
                case "G": return 3;
                case "D": return 4;
                case "H": return 5;
                case "U": return 6;
                case "V": return 6;
                case "Z": return 7;
                case "CH": return 8;
                case "T": return 9;
                case "J": return 10;
                case "I": return 10;
                case "Y": return 10;
                case "W": return 12; // V == 6: return W == VV: return 6 + 6 == 12
                case "K": return 20;
                case "L": return 30;
                case "M": return 40;
                case "N": return 50;
                case "S": return 60;
                case "A'A": return 70;
                case "P": return 80;
                case "TZ": return 90;
                case "Q": return 100;
                case "R": return 200;
                case "SH": return 300;
                case "TH": return 400;
                // below are "finals" represented by concatenating a period to the input of this function
                case "K.": return 500;
                case "M.": return 600;
                case "N.": return 700;
                case "P.": return 800;
                case "TZ.": return 900;
                default: return 0;
            }
        }

        private int isopsephy(string letter) // this only takes a "letter" and outputs a number. (dipthongs are letters)
        {
            switch (letter)
            {
                case "A": return 1;
                case "B": return 2;
                case "G": return 3;
                case "D": return 4;
                case "E": return 5;
                case "W": return 6;
                case "Z": return 7;
                case "H": return 8;
                case "TH": return 9;
                case "I": return 10;
                case "K": return 20;
                case "L": return 30;
                case "M": return 40;
                case "N": return 50;
                case "X": return 60;
                case "O": return 70;
                case "P": return 80;
                case "Q": return 90;
                case "R": return 100;
                case "S": return 200;
                case "T": return 300;
                case "U": return 400;
                case "Y": return 400;
                case "PH": return 500;
                case "CH": return 600;
                case "PS": return 700;
                case "@": return 800; // OMEGA stand-in for keyboards that do not have it
                case "Ω": return 800;
                case "TS": return 900;
                default: return 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            populateCipher();
        }

        /*
         * this function determines which cipher to use.
         * 
         * 0 = NAEQ6
         * 1 = Simple Gematria
         * 2 = Isopsephy
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
            
            int[] cipher_numbers = cipher_convert(cipher_dipthongs, comboBox1.SelectedIndex);
            string[] cipher_numbers_string = null;
            Array.Resize(ref cipher_numbers_string, cipher_numbers.Length);
            for (int i = 0; i < cipher_numbers.Length; i++)
            {
                cipher_numbers_string[i] = cipher_numbers[i].ToString();
            }
            label2.Text = string.Join(" + ", cipher_numbers_string.Where(s => !string.IsNullOrEmpty(s)));

            label3.Text = cipher_numbers.Sum().ToString();
        }

        private int[] cipher_convert(string[] cipher_letters, int cipher_control)
        {
            int[] cipher_numbers = null;
            Array.Resize(ref cipher_numbers, cipher_letters.Length);

            if (cipher_control == 2) // isopsephy
            {
                for (int letter = 0; letter < cipher_letters.Length; letter++)
                {
                    cipher_numbers[letter] = isopsephy(cipher_letters[letter]);
                }
            }
            else if (cipher_control == 1) // simple gematria
            {
                for (int letter = 0; letter < cipher_letters.Length; letter++)
                {
                    if (letter == cipher_letters.Length - 1)
                    {
                        switch(cipher_letters[letter]) // the below is for final letters only.
                        {
                            case "K": cipher_letters[letter] = "K."; break;
                            case "M": cipher_letters[letter] = "M."; break;
                            case "N": cipher_letters[letter] = "N."; break;
                            case "P": cipher_letters[letter] = "P."; break;
                            default: break;
                        }
                    }
                    if (letter == cipher_letters.Length - 2 && cipher_letters[letter] == "TZ")
                    {
                        cipher_letters[letter] = "TZ.";
                    }

                    cipher_numbers[letter] = simpleGematria(cipher_letters[letter]);
                }
            }
            else // NAEQ6
            {
                for (int letter = 0; letter < cipher_letters.Length; letter++)
                {
                    cipher_numbers[letter] = NAEQ6(cipher_letters[letter]);
                }
            }

            return cipher_numbers;
        }

        private string[] dipthong_join(string[] cipher_letters, List<string> dipthong_list)
        {

            foreach (string dipthong in dipthong_list)
            {
                for (int letter = 0; letter <= cipher_letters.Length - dipthong.Length; letter++) // only goes to the last letter that could possibly be in a dipthong
                {
                    if (!string.IsNullOrEmpty(cipher_letters[letter]) && !string.IsNullOrEmpty(cipher_letters[letter + 1]) && cipher_letters[letter][0] == dipthong[0] && cipher_letters[letter + 1][0] == dipthong[1]) //checks if first two letters match
                    {
                        if (dipthong.Length == 3 && !string.IsNullOrEmpty(cipher_letters[letter+ 2]) && cipher_letters[letter + 2][0] == dipthong[2])
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
