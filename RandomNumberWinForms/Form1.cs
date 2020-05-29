using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberService;
using RandomNumberService.Models;

namespace RandomNumberWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomNumberGeneratorService service = new RandomNumberGeneratorService();

            var numbers = service.GetRandomNumbers();
            List<string> numbersList = new List<string>();

            numbersList.Add(numbers.RandomNumber1.ToString());
            numbersList.Add(numbers.RandomNumber2.ToString());
            numbersList.Add(numbers.RandomNumber3.ToString());

            this.richTextBox1.Clear();

            StringBuilder sb = new StringBuilder();
            foreach (string item in numbersList)
            {
                sb.Append(item + " ");
            }

            richTextBox1.Text = sb.ToString();

        }
    }
}
