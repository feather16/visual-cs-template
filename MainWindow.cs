using System;
using System.Windows.Forms;

namespace Sample
{
    public class MainWindow : Form
    {
        public MainWindow()
        {
			SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            Console.WriteLine("Hello!");
        }
    }
}