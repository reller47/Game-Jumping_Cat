namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerGround = new System.Windows.Forms.Timer(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.pictureGround = new System.Windows.Forms.PictureBox();
            this.pictureGround2 = new System.Windows.Forms.PictureBox();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timerFall = new System.Windows.Forms.Timer(this.components);
            this.bomb = new System.Windows.Forms.PictureBox();
            this.bomb2 = new System.Windows.Forms.PictureBox();
            this.panelLose = new System.Windows.Forms.Panel();
            this.finalScore = new System.Windows.Forms.Label();
            this.buttonLose = new System.Windows.Forms.Button();
            this.labelLose = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.PictureBox();
            this.countScores = new System.Windows.Forms.Label();
            this.cloudScore = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.soundOffButton = new System.Windows.Forms.PictureBox();
            this.soundButton = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).BeginInit();
            this.panelLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOffButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundButton)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGround
            // 
            this.timerGround.Enabled = true;
            this.timerGround.Interval = 20;
            this.timerGround.Tick += new System.EventHandler(this.timerGround_Tick);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Cyan;
            this.panelControl.Controls.Add(this.soundOffButton);
            this.panelControl.Controls.Add(this.soundButton);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.restartButton);
            this.panelControl.Controls.Add(this.closeButton);
            this.panelControl.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(750, 30);
            this.panelControl.TabIndex = 0;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            this.panelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jumping Cat";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restartButton.BackgroundImage")));
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Location = new System.Drawing.Point(643, 3);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(25, 25);
            this.restartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartButton.TabIndex = 7;
            this.restartButton.TabStop = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.ErrorImage = null;
            this.closeButton.InitialImage = null;
            this.closeButton.Location = new System.Drawing.Point(721, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureGround
            // 
            this.pictureGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureGround.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ground;
            this.pictureGround.Location = new System.Drawing.Point(0, 620);
            this.pictureGround.Name = "pictureGround";
            this.pictureGround.Size = new System.Drawing.Size(750, 130);
            this.pictureGround.TabIndex = 1;
            this.pictureGround.TabStop = false;
            // 
            // pictureGround2
            // 
            this.pictureGround2.BackColor = System.Drawing.Color.Transparent;
            this.pictureGround2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ground;
            this.pictureGround2.Location = new System.Drawing.Point(750, 620);
            this.pictureGround2.Name = "pictureGround2";
            this.pictureGround2.Size = new System.Drawing.Size(750, 130);
            this.pictureGround2.TabIndex = 2;
            this.pictureGround2.TabStop = false;
            // 
            // pictureBackground
            // 
            this.pictureBackground.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background_fix1;
            this.pictureBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(750, 750);
            this.pictureBackground.TabIndex = 3;
            this.pictureBackground.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.Location = new System.Drawing.Point(100, 554);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 65);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // timerFall
            // 
            this.timerFall.Enabled = true;
            this.timerFall.Interval = 500;
            this.timerFall.Tick += new System.EventHandler(this.timerFall_Tick);
            // 
            // bomb
            // 
            this.bomb.BackColor = System.Drawing.Color.Transparent;
            this.bomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bomb.BackgroundImage")));
            this.bomb.Location = new System.Drawing.Point(350, 589);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(32, 32);
            this.bomb.TabIndex = 5;
            this.bomb.TabStop = false;
            // 
            // bomb2
            // 
            this.bomb2.BackColor = System.Drawing.Color.Transparent;
            this.bomb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bomb2.BackgroundImage")));
            this.bomb2.Location = new System.Drawing.Point(560, 589);
            this.bomb2.Name = "bomb2";
            this.bomb2.Size = new System.Drawing.Size(32, 32);
            this.bomb2.TabIndex = 6;
            this.bomb2.TabStop = false;
            // 
            // panelLose
            // 
            this.panelLose.BackColor = System.Drawing.Color.Black;
            this.panelLose.Controls.Add(this.finalScore);
            this.panelLose.Controls.Add(this.buttonLose);
            this.panelLose.Controls.Add(this.labelLose);
            this.panelLose.Location = new System.Drawing.Point(175, 275);
            this.panelLose.Name = "panelLose";
            this.panelLose.Size = new System.Drawing.Size(400, 260);
            this.panelLose.TabIndex = 7;
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.BackColor = System.Drawing.Color.Transparent;
            this.finalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalScore.Location = new System.Drawing.Point(109, 117);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(108, 25);
            this.finalScore.TabIndex = 9;
            this.finalScore.Text = "Score:    ";
            // 
            // buttonLose
            // 
            this.buttonLose.BackColor = System.Drawing.Color.Black;
            this.buttonLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLose.ForeColor = System.Drawing.Color.Red;
            this.buttonLose.Location = new System.Drawing.Point(109, 180);
            this.buttonLose.Name = "buttonLose";
            this.buttonLose.Size = new System.Drawing.Size(182, 54);
            this.buttonLose.TabIndex = 8;
            this.buttonLose.Text = "Restart";
            this.buttonLose.UseVisualStyleBackColor = false;
            this.buttonLose.Click += new System.EventHandler(this.buttonLose_Click);
            this.buttonLose.MouseEnter += new System.EventHandler(this.buttonLose_MouseEnter);
            this.buttonLose.MouseLeave += new System.EventHandler(this.buttonLose_MouseLeave);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.Red;
            this.labelLose.Location = new System.Drawing.Point(23, 23);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(353, 57);
            this.labelLose.TabIndex = 8;
            this.labelLose.Text = "GAME OVER !";
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin.BackgroundImage")));
            this.coin.Location = new System.Drawing.Point(455, 599);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(22, 22);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 8;
            this.coin.TabStop = false;
            // 
            // countScores
            // 
            this.countScores.AutoSize = true;
            this.countScores.BackColor = System.Drawing.Color.Chocolate;
            this.countScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countScores.ForeColor = System.Drawing.Color.White;
            this.countScores.Location = new System.Drawing.Point(356, 45);
            this.countScores.Name = "countScores";
            this.countScores.Size = new System.Drawing.Size(53, 25);
            this.countScores.TabIndex = 9;
            this.countScores.Text = ": 0  ";
            // 
            // cloudScore
            // 
            this.cloudScore.BackColor = System.Drawing.Color.Transparent;
            this.cloudScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloudScore.BackgroundImage")));
            this.cloudScore.Location = new System.Drawing.Point(312, 33);
            this.cloudScore.Name = "cloudScore";
            this.cloudScore.Size = new System.Drawing.Size(126, 50);
            this.cloudScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudScore.TabIndex = 10;
            this.cloudScore.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerSound
            // 
            this.timerSound.Enabled = true;
            this.timerSound.Interval = 14780;
            this.timerSound.Tick += new System.EventHandler(this.timerSound_Tick);
            // 
            // soundOffButton
            // 
            this.soundOffButton.BackColor = System.Drawing.Color.Transparent;
            this.soundOffButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundOffButton.Image = ((System.Drawing.Image)(resources.GetObject("soundOffButton.Image")));
            this.soundOffButton.Location = new System.Drawing.Point(565, 3);
            this.soundOffButton.Name = "soundOffButton";
            this.soundOffButton.Size = new System.Drawing.Size(24, 24);
            this.soundOffButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundOffButton.TabIndex = 12;
            this.soundOffButton.TabStop = false;
            this.soundOffButton.Click += new System.EventHandler(this.soundOffButton_Click);
            // 
            // soundButton
            // 
            this.soundButton.BackColor = System.Drawing.Color.Transparent;
            this.soundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundButton.Image = ((System.Drawing.Image)(resources.GetObject("soundButton.Image")));
            this.soundButton.Location = new System.Drawing.Point(565, 3);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(24, 24);
            this.soundButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundButton.TabIndex = 13;
            this.soundButton.TabStop = false;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countScores);
            this.Controls.Add(this.cloudScore);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.panelLose);
            this.Controls.Add(this.bomb2);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureGround2);
            this.Controls.Add(this.pictureGround);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.pictureBackground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumping Cat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).EndInit();
            this.panelLose.ResumeLayout(false);
            this.panelLose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundOffButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureGround;
        private System.Windows.Forms.PictureBox pictureGround2;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timerFall;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox bomb2;
        private System.Windows.Forms.Timer timerGround;
        private System.Windows.Forms.PictureBox restartButton;
        private System.Windows.Forms.Panel panelLose;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button buttonLose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label countScores;
        private System.Windows.Forms.PictureBox cloudScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label finalScore;
        private System.Windows.Forms.Timer timerSound;
        private System.Windows.Forms.PictureBox soundOffButton;
        private System.Windows.Forms.PictureBox soundButton;
    }
}

