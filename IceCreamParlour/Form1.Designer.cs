namespace IceCreamParlour
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.coneInput = new System.Windows.Forms.TextBox();
            this.DrinkOutput = new System.Windows.Forms.TextBox();
            this.DipOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalOutput = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.OutputTax = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Ribbon131 BT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "I Scream";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(233, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 378);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "How many cones?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "how many drinks would you like?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "dipped?";
            // 
            // coneInput
            // 
            this.coneInput.Location = new System.Drawing.Point(168, 90);
            this.coneInput.Name = "coneInput";
            this.coneInput.Size = new System.Drawing.Size(59, 20);
            this.coneInput.TabIndex = 9;
            // 
            // DrinkOutput
            // 
            this.DrinkOutput.Location = new System.Drawing.Point(168, 113);
            this.DrinkOutput.Name = "DrinkOutput";
            this.DrinkOutput.Size = new System.Drawing.Size(59, 20);
            this.DrinkOutput.TabIndex = 10;
            // 
            // DipOutput
            // 
            this.DipOutput.Location = new System.Drawing.Point(168, 135);
            this.DipOutput.Name = "DipOutput";
            this.DipOutput.Size = new System.Drawing.Size(59, 20);
            this.DipOutput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculate total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sub Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "New Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 17;
            // 
            // TotalOutput
            // 
            this.TotalOutput.AutoSize = true;
            this.TotalOutput.Location = new System.Drawing.Point(172, 275);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(41, 13);
            this.TotalOutput.TabIndex = 19;
            this.TotalOutput.Text = "label12";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.Location = new System.Drawing.Point(172, 228);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(41, 13);
            this.subTotalOutput.TabIndex = 20;
            this.subTotalOutput.Text = "label13";
            // 
            // OutputTax
            // 
            this.OutputTax.AutoSize = true;
            this.OutputTax.Location = new System.Drawing.Point(172, 252);
            this.OutputTax.Name = "OutputTax";
            this.OutputTax.Size = new System.Drawing.Size(41, 13);
            this.OutputTax.TabIndex = 21;
            this.OutputTax.Text = "label11";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(61, 334);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 22;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.OutputTax);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DipOutput);
            this.Controls.Add(this.DrinkOutput);
            this.Controls.Add(this.coneInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coneInput;
        private System.Windows.Forms.TextBox DrinkOutput;
        private System.Windows.Forms.TextBox DipOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TotalOutput;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label OutputTax;
        private System.Windows.Forms.Button printButton;
    }
}

