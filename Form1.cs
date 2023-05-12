using System;

namespace OS12thProject
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public int Number_Of_Processes;
        public int Number_Of_Resource;

        public Form1()
        {
            InitializeComponent();

            Instance = this;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Number_Of_Processes = int.Parse(textBox1.Text);// = int.Parse(Console.ReadLine());

                Number_Of_Resource = int.Parse(textBox2.Text);//= int.Parse(Console.ReadLine());
            }
            catch(Exception exep) 
            {
                MessageBox.Show(exep.Message);
            
            }
            this.Hide();
            Entring_Max_Matrix page2 = new Entring_Max_Matrix();
            page2.Show(this);
         
        }
    }
}