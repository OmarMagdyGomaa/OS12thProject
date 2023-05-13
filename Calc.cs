using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace OS12thProject
{
    public partial class Calc : Form
    {
        public static Calc Instance;
        int count = 0;
        
        int[] safeSequence = new int[1000];
        public Calc()
        {
            InitializeComponent();

            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Safe_Seq = new List<string>();

            while (count < Form1.Number_Of_Processes)
            {
                bool found = false;
                for (int i = 0; i < Form1.Number_Of_Processes; i++)
                {
                    if (!Available.finish[i])
                    {
                        bool canExecute = true;
                        for (int j = 0; j < Form1.Number_Of_Resource; j++)
                        {
                            if (Entring_Max_Matrix.maximum[i, j] > Available.available[j] + Allocated.allocation[i, j])
                            {
                                canExecute = false;
                                break;
                            }
                        }
                        if (canExecute)
                        {
                            for (int j = 0; j < Form1.Number_Of_Resource; j++)
                            {
                                Available.available[j] += Allocated.allocation[i, j];
                            }
                            Available.finish[i] = true;
                            safeSequence[count] = i;
                            count++;
                            found = true;
                            Safe_Seq.Add("Process " + i + " -> "); // add process name to Safe_Seq
                        }
                    }
                }
                string ans = "";
                foreach (var proc in Safe_Seq)
                {
                    ans += proc;
                }

                
                //Safe_Seq =Safe_Seq.Last();
                if (!found)
                {
                    MessageBox.Show("Unsafe state - deadlock detected.");
                    this.Close();
                    break;
                }
                else
                {
                    ans = ans.Remove(ans.Length - 3);
                    textBox1.Text = ans;
                }
            }




        }
    }
}
