namespace OS12thProject
{
    partial class Allocated
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter the Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(538, 25);
            label1.Name = "label1";
            label1.Size = new Size(195, 35);
            label1.TabIndex = 6;
            label1.Text = "Allocated Matrix";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1401, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 150);
            label3.Name = "label3";
            label3.Size = new Size(352, 20);
            label3.TabIndex = 16;
            label3.Text = "Enter All The Values At Once Delimeted By A Space ";
            // 
            // button1
            // 
            button1.Location = new Point(626, 302);
            button1.Name = "button1";
            button1.Size = new Size(188, 67);
            button1.TabIndex = 17;
            button1.Text = "ADD & NEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Allocated
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Allocated";
            Text = "Allocated";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}