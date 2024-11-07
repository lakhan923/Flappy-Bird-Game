namespace FlappingBirdGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            pipeBottom = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(734, -4);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(95, 216);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(130, 182);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(88, 81);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // ground
            // 
            ground.BackColor = Color.Transparent;
            ground.BackgroundImage = Properties.Resources.ground;
            ground.Location = new Point(-17, 589);
            ground.Name = "ground";
            ground.Size = new Size(909, 89);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(509, 383);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(101, 209);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 3;
            pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AllowDrop = true;
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(2, 617);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(152, 43);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(853, 669);
            Controls.Add(scoreText);
            Controls.Add(pipeBottom);
            Controls.Add(ground);
            Controls.Add(flappyBird);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Flappy Bird Game";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox ground;
        private PictureBox pipeBottom;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
