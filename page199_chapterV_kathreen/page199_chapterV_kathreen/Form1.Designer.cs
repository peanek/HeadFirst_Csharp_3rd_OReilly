namespace page199_chapterV_kathreen
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
            this.numericPeople = new System.Windows.Forms.NumericUpDown();
            this.checkboxFancy = new System.Windows.Forms.CheckBox();
            this.checkboxHealthyOption = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPeople
            // 
            this.numericPeople.Location = new System.Drawing.Point(13, 13);
            this.numericPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericPeople.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPeople.Name = "numericPeople";
            this.numericPeople.Size = new System.Drawing.Size(120, 20);
            this.numericPeople.TabIndex = 0;
            this.numericPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPeople.ValueChanged += new System.EventHandler(this.numericPeople_ValueChanged);
            // 
            // checkboxFancy
            // 
            this.checkboxFancy.AutoSize = true;
            this.checkboxFancy.Checked = true;
            this.checkboxFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxFancy.Location = new System.Drawing.Point(13, 40);
            this.checkboxFancy.Name = "checkboxFancy";
            this.checkboxFancy.Size = new System.Drawing.Size(115, 17);
            this.checkboxFancy.TabIndex = 1;
            this.checkboxFancy.Text = "Fancy Decorations";
            this.checkboxFancy.UseVisualStyleBackColor = true;
            this.checkboxFancy.CheckedChanged += new System.EventHandler(this.checkboxFancy_CheckedChanged);
            // 
            // checkboxHealthyOption
            // 
            this.checkboxHealthyOption.AutoSize = true;
            this.checkboxHealthyOption.Location = new System.Drawing.Point(13, 63);
            this.checkboxHealthyOption.Name = "checkboxHealthyOption";
            this.checkboxHealthyOption.Size = new System.Drawing.Size(96, 17);
            this.checkboxHealthyOption.TabIndex = 2;
            this.checkboxHealthyOption.Text = "Healthy Option";
            this.checkboxHealthyOption.UseVisualStyleBackColor = true;
            this.checkboxHealthyOption.CheckedChanged += new System.EventHandler(this.checkboxHealthyOption_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.Location = new System.Drawing.Point(45, 87);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 20);
            this.costLabel.TabIndex = 3;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(13, 93);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(27, 13);
            this.cost.TabIndex = 4;
            this.cost.Text = "cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.checkboxHealthyOption);
            this.Controls.Add(this.checkboxFancy);
            this.Controls.Add(this.numericPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericPeople;
        private System.Windows.Forms.CheckBox checkboxFancy;
        private System.Windows.Forms.CheckBox checkboxHealthyOption;
        private System.Windows.Forms.TextBox costLabel;
        private System.Windows.Forms.Label cost;
    }
}

