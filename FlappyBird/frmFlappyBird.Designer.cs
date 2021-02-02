
namespace FlappyBird1
{
    partial class frmFlappyBird
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
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.PcPipeTop = new System.Windows.Forms.PictureBox();
            this.PcGround = new System.Windows.Forms.PictureBox();
            this.PcPipeDown = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 500);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(91, 44);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Start";
            this.lblScore.Click += new System.EventHandler(this.btnstart);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 17;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // PcPipeTop
            // 
            this.PcPipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PcPipeTop.Image = global::FlappyBird1.Properties.Resources.PipeTop;
            this.PcPipeTop.Location = new System.Drawing.Point(381, -252);
            this.PcPipeTop.Name = "PcPipeTop";
            this.PcPipeTop.Size = new System.Drawing.Size(100, 356);
            this.PcPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcPipeTop.TabIndex = 3;
            this.PcPipeTop.TabStop = false;
            // 
            // PcGround
            // 
            this.PcGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PcGround.Image = global::FlappyBird1.Properties.Resources.Ground;
            this.PcGround.Location = new System.Drawing.Point(0, 439);
            this.PcGround.Name = "PcGround";
            this.PcGround.Size = new System.Drawing.Size(544, 114);
            this.PcGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcGround.TabIndex = 2;
            this.PcGround.TabStop = false;
            // 
            // PcPipeDown
            // 
            this.PcPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.PcPipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PcPipeDown.Image = global::FlappyBird1.Properties.Resources.PipeBottom;
            this.PcPipeDown.Location = new System.Drawing.Point(223, 338);
            this.PcPipeDown.Name = "PcPipeDown";
            this.PcPipeDown.Size = new System.Drawing.Size(100, 356);
            this.PcPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcPipeDown.TabIndex = 1;
            this.PcPipeDown.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Transparent;
            this.FlappyBird.Image = global::FlappyBird1.Properties.Resources.FlappyBird;
            this.FlappyBird.Location = new System.Drawing.Point(26, 175);
            this.FlappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(77, 68);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // frmFlappyBird
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FlappyBird1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(544, 553);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.PcGround);
            this.Controls.Add(this.PcPipeTop);
            this.Controls.Add(this.PcPipeDown);
            this.Controls.Add(this.FlappyBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.PcPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PcPipeDown;
        private System.Windows.Forms.PictureBox PcGround;
        private System.Windows.Forms.PictureBox PcPipeTop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
    }
}