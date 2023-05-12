namespace OS12thProject
{
    partial class Entring_Max_Matrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1193, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(210, 32);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 1;
            label1.Text = "Max Matrix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter the Value";
            // 
            // button1
            // 
            button1.Location = new Point(649, 273);
            button1.Name = "button1";
            button1.Size = new Size(188, 67);
            button1.TabIndex = 3;
            button1.Text = "ADD & NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 121);
            label3.Name = "label3";
            label3.Size = new Size(352, 20);
            label3.TabIndex = 16;
            label3.Text = "Enter All The Values At Once Delimeted By A Space ";
            // 
            // Entring_Max_Matrix
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 507);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Entring_Max_Matrix";
            Text = "Entring_Max_Matrix";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}