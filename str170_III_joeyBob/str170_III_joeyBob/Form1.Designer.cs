namespace str170_III_joeyBob
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
            this.take5fromBob = new System.Windows.Forms.Button();
            this.give10Joey = new System.Windows.Forms.Button();
            this.joeyLabel = new System.Windows.Forms.Label();
            this.bobLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.joeGives10toBob = new System.Windows.Forms.Button();
            this.bobGives5toJoey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // take5fromBob
            // 
            this.take5fromBob.AutoSize = true;
            this.take5fromBob.Location = new System.Drawing.Point(222, 171);
            this.take5fromBob.Name = "take5fromBob";
            this.take5fromBob.Size = new System.Drawing.Size(151, 23);
            this.take5fromBob.TabIndex = 0;
            this.take5fromBob.Text = "button2";
            this.take5fromBob.UseVisualStyleBackColor = true;
            this.take5fromBob.Click += new System.EventHandler(this.take5fromBob_Click);
            // 
            // give10Joey
            // 
            this.give10Joey.AutoSize = true;
            this.give10Joey.Location = new System.Drawing.Point(64, 171);
            this.give10Joey.Name = "give10Joey";
            this.give10Joey.Size = new System.Drawing.Size(152, 23);
            this.give10Joey.TabIndex = 0;
            this.give10Joey.Text = "button1";
            this.give10Joey.UseVisualStyleBackColor = true;
            this.give10Joey.Click += new System.EventHandler(this.give10Joey_Click);
            // 
            // joeyLabel
            // 
            this.joeyLabel.AutoSize = true;
            this.joeyLabel.Location = new System.Drawing.Point(61, 22);
            this.joeyLabel.Name = "joeyLabel";
            this.joeyLabel.Size = new System.Drawing.Size(29, 13);
            this.joeyLabel.TabIndex = 1;
            this.joeyLabel.Text = "label";
            // 
            // bobLabel
            // 
            this.bobLabel.AutoSize = true;
            this.bobLabel.Location = new System.Drawing.Point(61, 70);
            this.bobLabel.Name = "bobLabel";
            this.bobLabel.Size = new System.Drawing.Size(29, 13);
            this.bobLabel.TabIndex = 1;
            this.bobLabel.Text = "label";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(61, 133);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(29, 13);
            this.bankLabel.TabIndex = 1;
            this.bankLabel.Text = "label";
            // 
            // joeGives10toBob
            // 
            this.joeGives10toBob.Location = new System.Drawing.Point(64, 199);
            this.joeGives10toBob.Name = "joeGives10toBob";
            this.joeGives10toBob.Size = new System.Drawing.Size(75, 23);
            this.joeGives10toBob.TabIndex = 2;
            this.joeGives10toBob.Text = "button1";
            this.joeGives10toBob.UseVisualStyleBackColor = true;
            this.joeGives10toBob.Click += new System.EventHandler(this.joeGives10toBob_Click);
            // 
            // bobGives5toJoey
            // 
            this.bobGives5toJoey.Location = new System.Drawing.Point(298, 199);
            this.bobGives5toJoey.Name = "bobGives5toJoey";
            this.bobGives5toJoey.Size = new System.Drawing.Size(75, 23);
            this.bobGives5toJoey.TabIndex = 2;
            this.bobGives5toJoey.Text = "button1";
            this.bobGives5toJoey.UseVisualStyleBackColor = true;
            this.bobGives5toJoey.Click += new System.EventHandler(this.bobGives5toJoey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 234);
            this.Controls.Add(this.bobGives5toJoey);
            this.Controls.Add(this.joeGives10toBob);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.bobLabel);
            this.Controls.Add(this.joeyLabel);
            this.Controls.Add(this.give10Joey);
            this.Controls.Add(this.take5fromBob);
            this.Name = "Form1";
            this.Text = "Joe and Bob FUN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button take5fromBob;
        private System.Windows.Forms.Button give10Joey;
        private System.Windows.Forms.Label joeyLabel;
        private System.Windows.Forms.Label bobLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Button joeGives10toBob;
        private System.Windows.Forms.Button bobGives5toJoey;
    }
}

