namespace ProjectCalculator
{
    partial class Calculator
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
            this.number_0 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number_0
            // 
            this.number_0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_0.Location = new System.Drawing.Point(12, 277);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(108, 46);
            this.number_0.TabIndex = 0;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = true;
            this.number_0.Click += new System.EventHandler(this.number_0_Click);
            // 
            // number_1
            // 
            this.number_1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_1.Location = new System.Drawing.Point(12, 222);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(51, 49);
            this.number_1.TabIndex = 3;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.number_1_Click);
            // 
            // number_2
            // 
            this.number_2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_2.Location = new System.Drawing.Point(69, 222);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(51, 49);
            this.number_2.TabIndex = 4;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.number_2_Click);
            // 
            // number_3
            // 
            this.number_3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_3.Location = new System.Drawing.Point(126, 222);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(51, 49);
            this.number_3.TabIndex = 5;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.number_3_Click);
            // 
            // number_4
            // 
            this.number_4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_4.Location = new System.Drawing.Point(12, 167);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(51, 49);
            this.number_4.TabIndex = 6;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.number_4_Click);
            // 
            // number_5
            // 
            this.number_5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_5.Location = new System.Drawing.Point(69, 167);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(51, 49);
            this.number_5.TabIndex = 7;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.number_5_Click);
            // 
            // number_6
            // 
            this.number_6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.number_6.Location = new System.Drawing.Point(126, 167);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(51, 49);
            this.number_6.TabIndex = 8;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.number_6_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 335);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.number_0);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_6;
    }
}

