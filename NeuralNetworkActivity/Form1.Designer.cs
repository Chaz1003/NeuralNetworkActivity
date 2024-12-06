namespace NeuralNetworkActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(107, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 33);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F);
            textBox2.Location = new Point(107, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 33);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F);
            textBox3.Location = new Point(414, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 33);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(173, 421);
            button1.Name = "button1";
            button1.Size = new Size(113, 72);
            button1.TabIndex = 3;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(341, 421);
            button2.Name = "button2";
            button2.Size = new Size(113, 72);
            button2.TabIndex = 4;
            button2.Text = "Train the Neural Net";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(510, 421);
            button3.Name = "button3";
            button3.Size = new Size(113, 72);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F);
            textBox4.Location = new Point(107, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 33);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F);
            textBox5.Location = new Point(107, 333);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 33);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F);
            textBox6.Location = new Point(614, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 33);
            textBox6.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(414, 228);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 9;
            label1.Text = "Real Output";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(614, 228);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 10;
            label2.Text = "Rounded Off";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(414, 60);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 11;
            label3.Text = "Minimum Epoch:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(107, 60);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 12;
            label4.Text = "Hidden Neurons: 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(579, 60);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 13;
            label5.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 583);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
