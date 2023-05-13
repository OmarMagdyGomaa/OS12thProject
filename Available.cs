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
    public partial class Available : Form
    {
        public static Available Instance;
        public static int[] available = new int[Form1.Number_Of_Resource];
        public static bool[] finish = new bool[Form1.Number_Of_Processes];
        public static int[,] need = new int[Form1.Number_Of_Processes, Form1.Number_Of_Resource];
        public static int[] work = new int[Form1.Number_Of_Resource];


        public Available()
        {
            Instance = this;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputAvailable = textBox1.Text.Split(' ');

                if (inputAvailable.Length != Form1.Number_Of_Resource)
                {
                    throw new Exception("Invalid input: must enter " + Form1.Number_Of_Resource + " integers separated by spaces.");
                }

                for (int j = 0; j < Form1.Number_Of_Resource; j++)
                {
                    int resource = int.Parse(inputAvailable[j]);

                    if (resource < 0)
                    {
                        throw new Exception("Invalid input: resource " + (j + 1) + " must be a non-negative integer.");
                    }

                    available[j] = resource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Validate the max matrix has been entered correctly
            /*try
            {
                for (int i = 0; i < Form1.Instance.Number_Of_Processes; i++)
                {
                    for (int j = 0; j < Form1.Instance.Number_Of_Resource; j++)
                    {
                        int maxResource = Entring_Max_Matrix.Instance.maximum[i, j];
                        int allocatedResource = Allocated.Instance.allocation[i, j];//error here

                        if (maxResource < allocatedResource)
                        {
                            throw new Exception("Invalid input: process " + (i + 1) + " max resource " + (j + 1) + " must be greater than or equal to allocated resource.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }*/

            for (int i = 0; i < Form1.Number_Of_Processes; i++)
                {
                    finish[i] = false;
                }
            


            // Initialize the work array to the available array
            for (int j = 0; j < Form1.Number_Of_Resource; j++)
            {
                work[j] = available[j];
            }

            // Find a safe sequence
            int[] safeSequence = new int[Form1.Number_Of_Processes];


            this.Hide();
            Calc page5 = new Calc();
            page5.Show(this);
        }
    }
}

