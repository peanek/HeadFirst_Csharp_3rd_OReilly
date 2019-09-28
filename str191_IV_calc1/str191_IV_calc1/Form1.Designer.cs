namespace str191_IV_calc1
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
            this.moneyToRecover = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.beginningNumeric = new System.Windows.Forms.NumericUpDown();
            this.endNumeric = new System.Windows.Forms.NumericUpDown();
            this.kmMessageBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beginningNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beginning counter state";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ening counter state";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money to recover";
            // 
            // moneyToRecover
            // 
            this.moneyToRecover.AutoSize = true;
            this.moneyToRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyToRecover.Location = new System.Drawing.Point(159, 63);
            this.moneyToRecover.Name = "moneyToRecover";
            this.moneyToRecover.Size = new System.Drawing.Size(57, 20);
            this.moneyToRecover.TabIndex = 3;
            this.moneyToRecover.Text = "label4";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(16, 100);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // beginningNumeric
            // 
            this.beginningNumeric.Location = new System.Drawing.Point(163, 13);
            this.beginningNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.beginningNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beginningNumeric.Name = "beginningNumeric";
            this.beginningNumeric.Size = new System.Drawing.Size(120, 20);
            this.beginningNumeric.TabIndex = 5;
            this.beginningNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumeric
            // 
            this.endNumeric.Location = new System.Drawing.Point(163, 40);
            this.endNumeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumeric.Name = "endNumeric";
            this.endNumeric.Size = new System.Drawing.Size(120, 20);
            this.endNumeric.TabIndex = 6;
            this.endNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kmMessageBox
            // 
            this.kmMessageBox.Location = new System.Drawing.Point(222, 100);
            this.kmMessageBox.Name = "kmMessageBox";
            this.kmMessageBox.Size = new System.Drawing.Size(75, 23);
            this.kmMessageBox.TabIndex = 7;
            this.kmMessageBox.Text = "KM info";
            this.kmMessageBox.UseVisualStyleBackColor = true;
            this.kmMessageBox.Click += new System.EventHandler(this.kmMessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 135);
            this.Controls.Add(this.kmMessageBox);
            this.Controls.Add(this.endNumeric);
            this.Controls.Add(this.beginningNumeric);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.moneyToRecover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Distance calc";
            ((System.ComponentModel.ISupportInitialize)(this.beginningNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moneyToRecover;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.NumericUpDown beginningNumeric;
        private System.Windows.Forms.NumericUpDown endNumeric;
        private System.Windows.Forms.Button kmMessageBox;
    }
}

