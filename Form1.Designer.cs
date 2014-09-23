namespace RPS_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scissorsRadio = new System.Windows.Forms.RadioButton();
            this.paperRadio = new System.Windows.Forms.RadioButton();
            this.rockRadio = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.losesLabel = new System.Windows.Forms.Label();
            this.drawsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userChoiceLabel = new System.Windows.Forms.Label();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.computerInputLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scissorsRadio);
            this.groupBox1.Controls.Add(this.paperRadio);
            this.groupBox1.Controls.Add(this.rockRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select one:";
            // 
            // scissorsRadio
            // 
            this.scissorsRadio.AutoSize = true;
            this.scissorsRadio.Location = new System.Drawing.Point(6, 65);
            this.scissorsRadio.Name = "scissorsRadio";
            this.scissorsRadio.Size = new System.Drawing.Size(64, 17);
            this.scissorsRadio.TabIndex = 2;
            this.scissorsRadio.TabStop = true;
            this.scissorsRadio.Text = "Scissors";
            this.scissorsRadio.UseVisualStyleBackColor = true;
            // 
            // paperRadio
            // 
            this.paperRadio.AutoSize = true;
            this.paperRadio.Location = new System.Drawing.Point(6, 42);
            this.paperRadio.Name = "paperRadio";
            this.paperRadio.Size = new System.Drawing.Size(53, 17);
            this.paperRadio.TabIndex = 1;
            this.paperRadio.TabStop = true;
            this.paperRadio.Text = "Paper";
            this.paperRadio.UseVisualStyleBackColor = true;
            // 
            // rockRadio
            // 
            this.rockRadio.AutoSize = true;
            this.rockRadio.Location = new System.Drawing.Point(6, 19);
            this.rockRadio.Name = "rockRadio";
            this.rockRadio.Size = new System.Drawing.Size(51, 17);
            this.rockRadio.TabIndex = 0;
            this.rockRadio.TabStop = true;
            this.rockRadio.Text = "Rock";
            this.rockRadio.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(79, 250);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 250);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(241, 250);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Clear History";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Draws:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(52, 16);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(0, 13);
            this.winsLabel.TabIndex = 7;
            // 
            // losesLabel
            // 
            this.losesLabel.AutoSize = true;
            this.losesLabel.Location = new System.Drawing.Point(52, 29);
            this.losesLabel.Name = "losesLabel";
            this.losesLabel.Size = new System.Drawing.Size(0, 13);
            this.losesLabel.TabIndex = 8;
            // 
            // drawsLabel
            // 
            this.drawsLabel.AutoSize = true;
            this.drawsLabel.Location = new System.Drawing.Point(52, 42);
            this.drawsLabel.Name = "drawsLabel";
            this.drawsLabel.Size = new System.Drawing.Size(0, 13);
            this.drawsLabel.TabIndex = 9;
            this.drawsLabel.Click += new System.EventHandler(this.drawsLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.drawsLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.losesLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.winsLabel);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 65);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History:";
            // 
            // userChoiceLabel
            // 
            this.userChoiceLabel.AutoSize = true;
            this.userChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userChoiceLabel.Location = new System.Drawing.Point(117, 129);
            this.userChoiceLabel.Name = "userChoiceLabel";
            this.userChoiceLabel.Size = new System.Drawing.Size(87, 16);
            this.userChoiceLabel.TabIndex = 11;
            this.userChoiceLabel.Text = "You Chose:";
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputLabel.Location = new System.Drawing.Point(217, 129);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(0, 16);
            this.userInputLabel.TabIndex = 12;
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.AutoSize = true;
            this.computerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerChoiceLabel.Location = new System.Drawing.Point(47, 146);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(157, 16);
            this.computerChoiceLabel.TabIndex = 13;
            this.computerChoiceLabel.Text = "The Computer Chose:";
            // 
            // computerInputLabel
            // 
            this.computerInputLabel.AutoSize = true;
            this.computerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerInputLabel.Location = new System.Drawing.Point(217, 146);
            this.computerInputLabel.Name = "computerInputLabel";
            this.computerInputLabel.Size = new System.Drawing.Size(0, 16);
            this.computerInputLabel.TabIndex = 14;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(148, 200);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 25);
            this.resultsLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 285);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.computerInputLabel);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.userChoiceLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton scissorsRadio;
        private System.Windows.Forms.RadioButton paperRadio;
        private System.Windows.Forms.RadioButton rockRadio;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label losesLabel;
        private System.Windows.Forms.Label drawsLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label userChoiceLabel;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label computerInputLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

