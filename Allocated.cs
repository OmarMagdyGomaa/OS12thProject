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
        public static int[,] allocation;

        public Allocated()
        {
            Instance = this;

            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            allocation = new int[Form1.Number_Of_Processes, Form1.Number_Of_Resource];
                    
            for (int i = 0; i < Form1.Number_Of_Processes; i++)
            {
                try
                {

                    string[] input = textBox1.Text.Split(' ');
                    if (input.Length != Form1.Number_Of_Resource*Form1.Number_Of_Processes)
                    {
                        throw new Exception("Incorrect number of resource values entered for process " + i);
                    }

                    for (int j = 0; j < Form1.Number_Of_Resource; j++)
                    {
                        
                        if (!int.TryParse(input[i], out int value))
                        {
                            throw new Exception("Invalid input entered for process " + i + ", resource " + j);
                        }
                        allocation[i, j] = value;
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                    return;
                }
            }
            this.Hide();
            Available page4 = new Available();
            page4.Show(this);
        }

    }
}
