using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auticko = new Auto("123-ABC", 3);
        private void button1_Click(object sender, EventArgs e)
        {
            auticko.Rozjed();
            MessageBox.Show(auticko.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auticko.Zastav(100);
            auticko.CelkovaSpotreba();
            MessageBox.Show(auticko.ToString());
        }
    }
}
