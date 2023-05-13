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
    public partial class Entring_Max_Matrix : Form
    {
        public static Entring_Max_Matrix Instance;
        public static int[,] maximum = new int[Form1.Number_Of_Processes, Form1.Number_Of_Resource];
        public static int count = 0;
        public Entring_Max_Matrix()
        {
            Instance = this;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] input = textBox1.Text.Split(' ');
                
                // Validate input
                if (input.Length != Form1.Number_Of_Resource * Form1.Number_Of_Processes)
                {
                    throw new Exception("Invalid input");
                }

                // Populate max matrix
                //count = 1;
                for (int i = 0; i < Form1.Number_Of_Processes; i++)
                {
                    for (int j = 0; j < Form1.Number_Of_Resource; j++)
                    {
                        int value = int.Parse(input[i+j]);
                        if (!int.TryParse(input[i+j], out value))
                        {
                            throw new Exception("Invalid input");
                        }
                        /*Entring_Max_Matrix.Instance.*/
                        maximum[i, j] = int.Parse(input[i + j]);



                        //count++;
                    }
                }

                // Hide current form and show next form
                this.Hide();
                Allocated page3 = new Allocated();
                page3.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
