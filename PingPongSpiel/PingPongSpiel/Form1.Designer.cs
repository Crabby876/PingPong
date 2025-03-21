namespace PingPongSpiel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Player2 = new PictureBox();
            UpBarrier = new PictureBox();
            DownBarrier = new PictureBox();
            Player1Goal = new PictureBox();
            Player2Goal = new PictureBox();
            Ball = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpBarrier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownBarrier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player1Goal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Goal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player1
            // 
            Player1.BackColor = SystemColors.ButtonHighlight;
            Player1.Location = new Point(1311, 273);
            Player1.Name = "Player1";
            Player1.Size = new Size(23, 138);
            Player1.TabIndex = 0;
            Player1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += TimerTick;
            // 
            // Player2
            // 
            Player2.BackColor = SystemColors.ButtonHighlight;
            Player2.Location = new Point(21, 273);
            Player2.Name = "Player2";
            Player2.Size = new Size(23, 138);
            Player2.TabIndex = 1;
            Player2.TabStop = false;
            // 
            // UpBarrier
            // 
            UpBarrier.BackColor = SystemColors.ButtonHighlight;
            UpBarrier.Location = new Point(0, 0);
            UpBarrier.Name = "UpBarrier";
            UpBarrier.Size = new Size(1353, 12);
            UpBarrier.TabIndex = 2;
            UpBarrier.TabStop = false;
            UpBarrier.Visible = false;
            // 
            // DownBarrier
            // 
            DownBarrier.BackColor = SystemColors.ButtonHighlight;
            DownBarrier.Location = new Point(-7, 733);
            DownBarrier.Name = "DownBarrier";
            DownBarrier.Size = new Size(1360, 12);
            DownBarrier.TabIndex = 3;
            DownBarrier.TabStop = false;
            DownBarrier.Visible = false;
            // 
            // Player1Goal
            // 
            Player1Goal.BackColor = SystemColors.ButtonHighlight;
            Player1Goal.Location = new Point(1340, 12);
            Player1Goal.Name = "Player1Goal";
            Player1Goal.Size = new Size(13, 733);
            Player1Goal.TabIndex = 4;
            Player1Goal.TabStop = false;
            Player1Goal.Visible = false;
            // 
            // Player2Goal
            // 
            Player2Goal.BackColor = SystemColors.ButtonHighlight;
            Player2Goal.Location = new Point(0, 17);
            Player2Goal.Name = "Player2Goal";
            Player2Goal.Size = new Size(10, 733);
            Player2Goal.TabIndex = 5;
            Player2Goal.TabStop = false;
            Player2Goal.Visible = false;
            // 
            // Ball
            // 
            Ball.BackColor = SystemColors.ButtonHighlight;
            Ball.Location = new Point(697, 345);
            Ball.Name = "Ball";
            Ball.Size = new Size(14, 17);
            Ball.TabIndex = 6;
            Ball.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 95);
            label1.TabIndex = 7;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1247, 29);
            label2.Name = "label2";
            label2.Size = new Size(87, 95);
            label2.TabIndex = 8;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1350, 742);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ball);
            Controls.Add(Player2Goal);
            Controls.Add(Player1Goal);
            Controls.Add(DownBarrier);
            Controls.Add(UpBarrier);
            Controls.Add(Player2);
            Controls.Add(Player1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpBarrier).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownBarrier).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player1Goal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Goal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Player1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Player2;
        private PictureBox UpBarrier;
        private PictureBox DownBarrier;
        private PictureBox Player1Goal;
        private PictureBox Player2Goal;
        private PictureBox Ball;
        private Label label1;
        private Label label2;
    }
}