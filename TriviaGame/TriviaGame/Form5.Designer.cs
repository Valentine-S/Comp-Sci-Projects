namespace TriviaGame
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.currentPlayer = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Choice1Label = new System.Windows.Forms.Label();
            this.Choice2Label = new System.Windows.Forms.Label();
            this.Choice3Label = new System.Windows.Forms.Label();
            this.Choice4Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automotive Trivia!";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(426, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 371);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 5);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(426, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 5);
            this.label4.TabIndex = 3;
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Location = new System.Drawing.Point(437, 37);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(13, 13);
            this.player1Name.TabIndex = 4;
            this.player1Name.Text = "?";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Location = new System.Drawing.Point(437, 66);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(13, 13);
            this.player1Score.TabIndex = 5;
            this.player1Score.Text = "?";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Location = new System.Drawing.Point(437, 134);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(13, 13);
            this.player2Name.TabIndex = 6;
            this.player2Name.Text = "?";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Location = new System.Drawing.Point(437, 164);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(13, 13);
            this.player2Score.TabIndex = 7;
            this.player2Score.Text = "?";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-2, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(430, 5);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Time Left";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(489, 328);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(30, 13);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "Time";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(426, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 5);
            this.label11.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(485, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentPlayer
            // 
            this.currentPlayer.AutoSize = true;
            this.currentPlayer.Location = new System.Drawing.Point(94, 9);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(41, 13);
            this.currentPlayer.TabIndex = 14;
            this.currentPlayer.Text = "label12";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(18, 51);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(35, 13);
            this.QuestionLabel.TabIndex = 15;
            this.QuestionLabel.Text = "label5";
            // 
            // Choice1Label
            // 
            this.Choice1Label.AutoSize = true;
            this.Choice1Label.Location = new System.Drawing.Point(18, 242);
            this.Choice1Label.Name = "Choice1Label";
            this.Choice1Label.Size = new System.Drawing.Size(35, 13);
            this.Choice1Label.TabIndex = 16;
            this.Choice1Label.Text = "label6";
            // 
            // Choice2Label
            // 
            this.Choice2Label.AutoSize = true;
            this.Choice2Label.Location = new System.Drawing.Point(18, 264);
            this.Choice2Label.Name = "Choice2Label";
            this.Choice2Label.Size = new System.Drawing.Size(35, 13);
            this.Choice2Label.TabIndex = 17;
            this.Choice2Label.Text = "label7";
            // 
            // Choice3Label
            // 
            this.Choice3Label.AutoSize = true;
            this.Choice3Label.Location = new System.Drawing.Point(18, 303);
            this.Choice3Label.Name = "Choice3Label";
            this.Choice3Label.Size = new System.Drawing.Size(35, 13);
            this.Choice3Label.TabIndex = 18;
            this.Choice3Label.Text = "label8";
            // 
            // Choice4Label
            // 
            this.Choice4Label.AutoSize = true;
            this.Choice4Label.Location = new System.Drawing.Point(18, 328);
            this.Choice4Label.Name = "Choice4Label";
            this.Choice4Label.Size = new System.Drawing.Size(41, 13);
            this.Choice4Label.TabIndex = 19;
            this.Choice4Label.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Player 1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(437, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Player 2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Current Player:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Choice4Label);
            this.Controls.Add(this.Choice3Label);
            this.Controls.Add(this.Choice2Label);
            this.Controls.Add(this.Choice1Label);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.currentPlayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label currentPlayer;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label Choice1Label;
        private System.Windows.Forms.Label Choice2Label;
        private System.Windows.Forms.Label Choice3Label;
        private System.Windows.Forms.Label Choice4Label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}