using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = textBox1.Text.Trim();
            MessageBox.Show("Number of the words is: " + CountWords(words),"Counter");
            //Trim премахва началните и крайните символи
        }
        // Нов метод където да запазим масива
        // Split разделя спрямо низове от думи
        private int CountWords(string words)
        {
            string[] allwords = words.Split(' ');
            return allwords.Length;
        }
    }
}
