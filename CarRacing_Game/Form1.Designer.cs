namespace CarRacing_Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.pbWin);
            this.panel1.Controls.Add(this.Car2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // explosion
            // 
            this.explosion.Location = new System.Drawing.Point(68, 327);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(77, 82);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 3;
            this.explosion.TabStop = false;
            this.explosion.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Car1
            // 
            this.Car1.Location = new System.Drawing.Point(66, 19);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(48, 82);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 2;
            this.Car1.TabStop = false;
            this.Car1.Tag = "carLeft";
            this.Car1.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pbWin
            // 
            this.pbWin.Location = new System.Drawing.Point(131, 152);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(214, 159);
            this.pbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWin.TabIndex = 6;
            this.pbWin.TabStop = false;
            this.pbWin.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Car2
            // 
            this.Car2.Location = new System.Drawing.Point(351, 109);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(48, 82);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 5;
            this.Car2.TabStop = false;
            this.Car2.Tag = "carRight";
            this.Car2.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // player
            // 
            this.player.Image = global::CarRacing_Game.Properties.Resources.violet;
            this.player.Location = new System.Drawing.Point(216, 385);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 82);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // roadTrack2
            // 
            this.roadTrack2.BackColor = System.Drawing.Color.Black;
            this.roadTrack2.Image = ((System.Drawing.Image)(resources.GetObject("roadTrack2.Image")));
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(474, 1073);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            this.roadTrack2.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Location = new System.Drawing.Point(0, 0);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(474, 1073);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(146, 593);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Black;
            this.lbScore.Location = new System.Drawing.Point(146, 541);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(146, 36);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "Score : 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbScore.Click += new System.EventHandler(this.GameTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 649);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.Timer gameTimer;
    }
}

