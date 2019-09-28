namespace str225_IV_labs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bookmakerGroup = new System.Windows.Forms.GroupBox();
            this.numericGreyhound = new System.Windows.Forms.NumericUpDown();
            this.greyhoundLabel = new System.Windows.Forms.Label();
            this.numericBetValue = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bets = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.albRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.greyOne = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.greyTwo = new System.Windows.Forms.PictureBox();
            this.greyThree = new System.Windows.Forms.PictureBox();
            this.greyFourth = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bookmakerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreyhound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyFourth)).BeginInit();
            this.SuspendLayout();
            // 
            // bookmakerGroup
            // 
            this.bookmakerGroup.Controls.Add(this.numericGreyhound);
            this.bookmakerGroup.Controls.Add(this.greyhoundLabel);
            this.bookmakerGroup.Controls.Add(this.numericBetValue);
            this.bookmakerGroup.Controls.Add(this.betButton);
            this.bookmakerGroup.Controls.Add(this.button1);
            this.bookmakerGroup.Controls.Add(this.alBetLabel);
            this.bookmakerGroup.Controls.Add(this.bobBetLabel);
            this.bookmakerGroup.Controls.Add(this.joeBetLabel);
            this.bookmakerGroup.Controls.Add(this.bets);
            this.bookmakerGroup.Controls.Add(this.name);
            this.bookmakerGroup.Controls.Add(this.albRadioButton);
            this.bookmakerGroup.Controls.Add(this.bobRadioButton);
            this.bookmakerGroup.Controls.Add(this.joeRadioButton);
            this.bookmakerGroup.Controls.Add(this.minimumBetLabel);
            this.bookmakerGroup.Location = new System.Drawing.Point(12, 283);
            this.bookmakerGroup.Name = "bookmakerGroup";
            this.bookmakerGroup.Size = new System.Drawing.Size(710, 166);
            this.bookmakerGroup.TabIndex = 0;
            this.bookmakerGroup.TabStop = false;
            this.bookmakerGroup.Text = "bookmakerGroup";
            // 
            // numericGreyhound
            // 
            this.numericGreyhound.Location = new System.Drawing.Point(258, 134);
            this.numericGreyhound.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericGreyhound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericGreyhound.Name = "numericGreyhound";
            this.numericGreyhound.Size = new System.Drawing.Size(40, 20);
            this.numericGreyhound.TabIndex = 13;
            this.numericGreyhound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // greyhoundLabel
            // 
            this.greyhoundLabel.AutoSize = true;
            this.greyhoundLabel.Location = new System.Drawing.Point(153, 139);
            this.greyhoundLabel.Name = "greyhoundLabel";
            this.greyhoundLabel.Size = new System.Drawing.Size(99, 13);
            this.greyhoundLabel.TabIndex = 12;
            this.greyhoundLabel.Text = "$ on greyhound no.";
            // 
            // numericBetValue
            // 
            this.numericBetValue.Location = new System.Drawing.Point(92, 134);
            this.numericBetValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericBetValue.Name = "numericBetValue";
            this.numericBetValue.Size = new System.Drawing.Size(55, 20);
            this.numericBetValue.TabIndex = 11;
            this.numericBetValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(51, 133);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(35, 24);
            this.betButton.TabIndex = 10;
            this.betButton.Text = "bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 107);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.alBetLabel.Location = new System.Drawing.Point(181, 109);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(264, 17);
            this.alBetLabel.TabIndex = 8;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bobBetLabel.Location = new System.Drawing.Point(181, 86);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(264, 17);
            this.bobBetLabel.TabIndex = 7;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joeBetLabel.Location = new System.Drawing.Point(181, 63);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(264, 17);
            this.joeBetLabel.TabIndex = 6;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // bets
            // 
            this.bets.AutoSize = true;
            this.bets.Location = new System.Drawing.Point(178, 34);
            this.bets.Name = "bets";
            this.bets.Size = new System.Drawing.Size(27, 13);
            this.bets.TabIndex = 5;
            this.bets.Text = "bets";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 141);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 4;
            this.name.Text = "name";
            // 
            // albRadioButton
            // 
            this.albRadioButton.AutoSize = true;
            this.albRadioButton.Location = new System.Drawing.Point(6, 109);
            this.albRadioButton.Name = "albRadioButton";
            this.albRadioButton.Size = new System.Drawing.Size(98, 17);
            this.albRadioButton.TabIndex = 3;
            this.albRadioButton.Text = "albRadioButton";
            this.albRadioButton.UseVisualStyleBackColor = true;
            this.albRadioButton.CheckedChanged += new System.EventHandler(this.albRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(6, 86);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(6, 63);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 35);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(89, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // greyOne
            // 
            this.greyOne.Image = ((System.Drawing.Image)(resources.GetObject("greyOne.Image")));
            this.greyOne.Location = new System.Drawing.Point(42, 58);
            this.greyOne.Name = "greyOne";
            this.greyOne.Size = new System.Drawing.Size(75, 20);
            this.greyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.greyOne.TabIndex = 1;
            this.greyOne.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(42, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(631, 204);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // greyTwo
            // 
            this.greyTwo.Image = ((System.Drawing.Image)(resources.GetObject("greyTwo.Image")));
            this.greyTwo.Location = new System.Drawing.Point(42, 106);
            this.greyTwo.Name = "greyTwo";
            this.greyTwo.Size = new System.Drawing.Size(75, 20);
            this.greyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.greyTwo.TabIndex = 6;
            this.greyTwo.TabStop = false;
            // 
            // greyThree
            // 
            this.greyThree.Image = ((System.Drawing.Image)(resources.GetObject("greyThree.Image")));
            this.greyThree.Location = new System.Drawing.Point(41, 161);
            this.greyThree.Name = "greyThree";
            this.greyThree.Size = new System.Drawing.Size(75, 20);
            this.greyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.greyThree.TabIndex = 7;
            this.greyThree.TabStop = false;
            // 
            // greyFourth
            // 
            this.greyFourth.Image = ((System.Drawing.Image)(resources.GetObject("greyFourth.Image")));
            this.greyFourth.Location = new System.Drawing.Point(41, 212);
            this.greyFourth.Name = "greyFourth";
            this.greyFourth.Size = new System.Drawing.Size(75, 20);
            this.greyFourth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.greyFourth.TabIndex = 8;
            this.greyFourth.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.greyFourth);
            this.Controls.Add(this.greyThree);
            this.Controls.Add(this.greyTwo);
            this.Controls.Add(this.greyOne);
            this.Controls.Add(this.bookmakerGroup);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bookmakerGroup.ResumeLayout(false);
            this.bookmakerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreyhound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyFourth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bookmakerGroup;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label bets;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RadioButton albRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericBetValue;
        private System.Windows.Forms.Label greyhoundLabel;
        private System.Windows.Forms.NumericUpDown numericGreyhound;
        private System.Windows.Forms.PictureBox greyOne;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox greyTwo;
        private System.Windows.Forms.PictureBox greyThree;
        private System.Windows.Forms.PictureBox greyFourth;
        private System.Windows.Forms.Timer timer1;
    }
}

