using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS12thProject
{
    public partial class Allocated : Form
    {
        public static Allocated Instance;
        public int[,] allocation;

        public Allocated()
        {
            Instance = this;

            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] allocation = new int[Form1.Instance.Number_Of_Processes, Form1.Instance.Number_Of_Resource];

            for (int i = 0; i < Form1.Instance.Number_Of_Processes; i++)
            {
                try
                {
                    Console.Write("Process " + i + ": ");
                    string[] input = textBox1.Text.Split(' ');
                    for (int j = 0; j < Form1.Instance.Number_Of_Resource; j++)
                    {
                        allocation[i, j] = int.Parse(input[j]);
                    }
                }
                catch (Exception exe)
                {

                    MessageBox.Show(exe.Message);

                }
            }
            this.Hide();
            Available page4 = new Available();
            page4.Show();

        }
    }
}
