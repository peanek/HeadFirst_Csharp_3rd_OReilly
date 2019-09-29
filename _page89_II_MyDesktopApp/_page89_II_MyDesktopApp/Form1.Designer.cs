namespace _page89_II_MyDesktopApp
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
            this.button_ChangeLabelPosition = new System.Windows.Forms.Button();
            this.checkBox_EnableLabelChanging = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ChangeLabelPosition
            // 
            this.button_ChangeLabelPosition.AutoSize = true;
            this.button_ChangeLabelPosition.Location = new System.Drawing.Point(13, 13);
            this.button_ChangeLabelPosition.Name = "button_ChangeLabelPosition";
            this.button_ChangeLabelPosition.Size = new System.Drawing.Size(150, 23);
            this.button_ChangeLabelPosition.TabIndex = 0;
            this.button_ChangeLabelPosition.Text = "Change the label if checked";
            this.button_ChangeLabelPosition.UseVisualStyleBackColor = true;
            this.button_ChangeLabelPosition.Click += new System.EventHandler(this.button_ChangeLabelPosition_Click);
            // 
            // checkBox_EnableLabelChanging
            // 
            this.checkBox_EnableLabelChanging.AutoSize = true;
            this.checkBox_EnableLabelChanging.Location = new System.Drawing.Point(459, 19);
            this.checkBox_EnableLabelChanging.Name = "checkBox_EnableLabelChanging";
            this.checkBox_EnableLabelChanging.Size = new System.Drawing.Size(131, 17);
            this.checkBox_EnableLabelChanging.TabIndex = 1;
            this.checkBox_EnableLabelChanging.Text = "Enable label changing";
            this.checkBox_EnableLabelChanging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_EnableLabelChanging.UseVisualStyleBackColor = true;
            this.checkBox_EnableLabelChanging.CheckedChanged += new System.EventHandler(this.checkBox_EnableLabelChanging_CheckedChanged);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(10, 86);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(591, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Press the button  to change my text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 118);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.checkBox_EnableLabelChanging);
            this.Controls.Add(this.button_ChangeLabelPosition);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ChangeLabelPosition;
        private System.Windows.Forms.CheckBox checkBox_EnableLabelChanging;
        private System.Windows.Forms.Label labelToChange;
    }
}

