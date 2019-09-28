namespace page226_V_cowsAndFarmers
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
            this.numericCows = new System.Windows.Forms.NumericUpDown();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cows";
            // 
            // numericCows
            // 
            this.numericCows.Location = new System.Drawing.Point(53, 5);
            this.numericCows.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericCows.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCows.Name = "numericCows";
            this.numericCows.Size = new System.Drawing.Size(120, 20);
            this.numericCows.TabIndex = 1;
            this.numericCows.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericCows.ValueChanged += new System.EventHandler(this.numericCows_ValueChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(53, 31);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(120, 23);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 94);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.numericCows);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericCows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericCows;
        private System.Windows.Forms.Button buttonCalc;
    }
}

