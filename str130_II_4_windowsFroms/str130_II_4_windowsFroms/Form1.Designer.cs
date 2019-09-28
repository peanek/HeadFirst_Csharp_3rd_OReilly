namespace str130_II_4_windowsFroms
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
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Location = new System.Drawing.Point(12, 12);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(124, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "click changes qtiquete";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(337, 16);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(135, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "ENABLE changes etiq.";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(0, 69);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(480, 13);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Click BUTTON to change tjext";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToChange.Click += new System.EventHandler(this.labelToChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 91);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "My win app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label labelToChange;
    }
}

