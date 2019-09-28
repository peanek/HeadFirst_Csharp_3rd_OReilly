namespace str201_IV_elephant
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
            this.loyd = new System.Windows.Forms.Button();
            this.lucinda = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loyd
            // 
            this.loyd.Location = new System.Drawing.Point(13, 13);
            this.loyd.Name = "loyd";
            this.loyd.Size = new System.Drawing.Size(75, 23);
            this.loyd.TabIndex = 0;
            this.loyd.Text = "loyd";
            this.loyd.UseVisualStyleBackColor = true;
            this.loyd.Click += new System.EventHandler(this.loyd_Click);
            // 
            // lucinda
            // 
            this.lucinda.Location = new System.Drawing.Point(12, 42);
            this.lucinda.Name = "lucinda";
            this.lucinda.Size = new System.Drawing.Size(75, 23);
            this.lucinda.TabIndex = 1;
            this.lucinda.Text = "lucinda";
            this.lucinda.UseVisualStyleBackColor = true;
            this.lucinda.Click += new System.EventHandler(this.lucinda_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(13, 71);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 2;
            this.change.Text = "change!";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.lucinda);
            this.Controls.Add(this.loyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CHANGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loyd;
        private System.Windows.Forms.Button lucinda;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button button1;
    }
}

