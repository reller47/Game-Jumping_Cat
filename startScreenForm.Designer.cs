namespace WindowsFormsApp1
{
    partial class startScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startScreenForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.timerBgStart = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.backgroundStart2 = new System.Windows.Forms.PictureBox();
            this.backgroundStart = new System.Windows.Forms.PictureBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStart)).BeginInit();
            this.SuspendLayout();
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
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Cyan;
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.closeButton);
            this.panelControl.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(750, 30);
            this.panelControl.TabIndex = 1;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            this.panelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseMove);
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
            // timerBgStart
            // 
            this.timerBgStart.Enabled = true;
            this.timerBgStart.Interval = 20;
            this.timerBgStart.Tick += new System.EventHandler(this.timerBgStart_Tick);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Maroon;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(194, 355);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(362, 70);
            this.label.TabIndex = 4;
            this.label.Text = "Jumping Cat";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            this.label.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // timerSound
            // 
            this.timerSound.Enabled = true;
            this.timerSound.Interval = 7480;
            this.timerSound.Tick += new System.EventHandler(this.timerSound_Tick);
            // 
            // backgroundStart2
            // 
            this.backgroundStart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundStart2.BackgroundImage")));
            this.backgroundStart2.Location = new System.Drawing.Point(750, 30);
            this.backgroundStart2.Name = "backgroundStart2";
            this.backgroundStart2.Size = new System.Drawing.Size(750, 750);
            this.backgroundStart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundStart2.TabIndex = 3;
            this.backgroundStart2.TabStop = false;
            // 
            // backgroundStart
            // 
            this.backgroundStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundStart.BackgroundImage")));
            this.backgroundStart.Location = new System.Drawing.Point(0, 30);
            this.backgroundStart.Name = "backgroundStart";
            this.backgroundStart.Size = new System.Drawing.Size(750, 750);
            this.backgroundStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundStart.TabIndex = 2;
            this.backgroundStart.TabStop = false;
            // 
            // startScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 780);
            this.Controls.Add(this.label);
            this.Controls.Add(this.backgroundStart2);
            this.Controls.Add(this.backgroundStart);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumping Cat";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox backgroundStart;
        private System.Windows.Forms.PictureBox backgroundStart2;
        private System.Windows.Forms.Timer timerBgStart;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timerSound;
    }
}