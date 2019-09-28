namespace page279_VI_queens
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAssignTheJobToABee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownShifts = new System.Windows.Forms.NumericUpDown();
            this.comboBoxJobsToDo = new System.Windows.Forms.ComboBox();
            this.buttonWorkTheNextShift = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssignTheJobToABee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownShifts);
            this.groupBox1.Controls.Add(this.comboBoxJobsToDo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignemts";
            // 
            // buttonAssignTheJobToABee
            // 
            this.buttonAssignTheJobToABee.Location = new System.Drawing.Point(6, 66);
            this.buttonAssignTheJobToABee.Name = "buttonAssignTheJobToABee";
            this.buttonAssignTheJobToABee.Size = new System.Drawing.Size(272, 23);
            this.buttonAssignTheJobToABee.TabIndex = 4;
            this.buttonAssignTheJobToABee.Text = "Assign the job to a bee";
            this.buttonAssignTheJobToABee.UseVisualStyleBackColor = true;
            this.buttonAssignTheJobToABee.Click += new System.EventHandler(this.buttonAssignTheJobToABee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job";
            // 
            // numericUpDownShifts
            // 
            this.numericUpDownShifts.Location = new System.Drawing.Point(199, 40);
            this.numericUpDownShifts.Name = "numericUpDownShifts";
            this.numericUpDownShifts.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownShifts.TabIndex = 1;
            // 
            // comboBoxJobsToDo
            // 
            this.comboBoxJobsToDo.FormattingEnabled = true;
            this.comboBoxJobsToDo.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.comboBoxJobsToDo.Location = new System.Drawing.Point(6, 40);
            this.comboBoxJobsToDo.Name = "comboBoxJobsToDo";
            this.comboBoxJobsToDo.Size = new System.Drawing.Size(186, 21);
            this.comboBoxJobsToDo.TabIndex = 0;
            // 
            // buttonWorkTheNextShift
            // 
            this.buttonWorkTheNextShift.Location = new System.Drawing.Point(304, 13);
            this.buttonWorkTheNextShift.Name = "buttonWorkTheNextShift";
            this.buttonWorkTheNextShift.Size = new System.Drawing.Size(133, 99);
            this.buttonWorkTheNextShift.TabIndex = 1;
            this.buttonWorkTheNextShift.Text = "Work the next shift";
            this.buttonWorkTheNextShift.UseVisualStyleBackColor = true;
            this.buttonWorkTheNextShift.Click += new System.EventHandler(this.buttonWorkTheNextShift_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(13, 118);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(424, 150);
            this.textBoxReport.TabIndex = 2;
            this.textBoxReport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonWorkTheNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAssignTheJobToABee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownShifts;
        private System.Windows.Forms.ComboBox comboBoxJobsToDo;
        private System.Windows.Forms.Button buttonWorkTheNextShift;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

