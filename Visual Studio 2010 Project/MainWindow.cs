using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainWindow : Form
    {
        private static List<char> _validCharacters = new List<char>() {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '-', '¬', '!', '_', '.', '?', '#', '&', '@', '%',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '_'
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string __seed = this.seedbox.Text;

            if (__seed.Length < 4)
            {
                MessageBox.Show("Please enter at least 4 character as a seed.");
                return;
            }
            
            byte[] __byteArray = System.Text.Encoding.UTF8.GetBytes(__seed);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(__byteArray);

            int __seedNumber = BitConverter.ToInt32(__byteArray, 0);

            Random __generator = new Random(__seedNumber);

            List<TextBox> __passwordBoxes = new List<TextBox>();
            __passwordBoxes.Add(this.password1box);
            __passwordBoxes.Add(this.password2box);
            __passwordBoxes.Add(this.password3box);
            __passwordBoxes.Add(this.password4box);
            __passwordBoxes.Add(this.password5box);
            __passwordBoxes.Add(this.password6box);
            __passwordBoxes.Add(this.password7box);
            __passwordBoxes.Add(this.password8box);
            __passwordBoxes.Add(this.password9box);
            __passwordBoxes.Add(this.password10box);
            __passwordBoxes.Add(this.password11box);
            __passwordBoxes.Add(this.password12box);

            foreach (var passwordBox in __passwordBoxes)
            {
                int __charCount = __generator.Next(4) + 8;
                string __password = "";
                for (int i = 0; i < __charCount; i++)
                {
                    __password += _validCharacters[__generator.Next(_validCharacters.Count -1)];
                }

                passwordBox.Text = __password;
            }
        }
    }
}
