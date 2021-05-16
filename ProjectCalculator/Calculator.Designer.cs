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
            this.SuspendLayout();
            // 
            // number_0
            // 
            this.number_0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_0.Location = new System.Drawing.Point(12, 277);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(89, 46);
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
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 335);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.number_0);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button number_1;
    }
}

