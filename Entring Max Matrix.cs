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
        public int[,] maximum;
        public Entring_Max_Matrix()
        {
            Instance = this;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] maximum = new int[Form1.Instance.Number_Of_Processes, Form1.Instance.Number_Of_Resource];


            // Read the maximum matrix from the user
            for (int i = 0; i < Form1.Instance.Number_Of_Processes; i++)
            {
                try
                {
                    string[] input = textBox1.Text.Split(' ');
                    for (int j = 0; j < Form1.Instance.Number_Of_Resource; j++)
                    {
                        maximum[i, j] = int.Parse(input[j]);
                    }
                }
                catch (Exception exe) {

                    MessageBox.Show(exe.Message);
                
                }
                this.Hide();
                Allocated page3= new Allocated();
                page3.Show();


            }
        }
    }
}
