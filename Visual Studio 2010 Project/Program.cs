using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            MainWindow __window = new MainWindow();
            __window.ShowDialog();
        }
    }
}
