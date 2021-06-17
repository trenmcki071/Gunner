
namespace Gunner
{
    partial class gunnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gunnerForm));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.explinationLabel = new System.Windows.Forms.Label();
            this.explinationLabel2 = new System.Windows.Forms.Label();
            this.explinationLabel1 = new System.Windows.Forms.Label();
            this.explinationLabel3 = new System.Windows.Forms.Label();
            this.boostLabel = new System.Windows.Forms.Label();
            this.boostLabel1 = new System.Windows.Forms.Label();
            this.explinationLabel5 = new System.Windows.Forms.Label();
            this.explinationLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player1ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(188, 23);
            this.player1ScoreLabel.TabIndex = 0;
            this.player1ScoreLabel.Text = "0";
            this.player1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player2ScoreLabel.Location = new System.Drawing.Point(400, 9);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(188, 23);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.Text = "0";
            this.player2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen
            // 
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.ForeColor = System.Drawing.Color.White;
            this.screen.Location = new System.Drawing.Point(-1, -1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(601, 403);
            this.screen.TabIndex = 2;
            this.screen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AllowDrop = true;
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Transparent;
            this.startButton.Location = new System.Drawing.Point(235, 315);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 50);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // explinationLabel
            // 
            this.explinationLabel.ForeColor = System.Drawing.Color.White;
            this.explinationLabel.Location = new System.Drawing.Point(12, 32);
            this.explinationLabel.Name = "explinationLabel";
            this.explinationLabel.Size = new System.Drawing.Size(188, 23);
            this.explinationLabel.TabIndex = 4;
            this.explinationLabel.Text = "PLAYER 1";
            this.explinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // explinationLabel2
            // 
            this.explinationLabel2.ForeColor = System.Drawing.Color.White;
            this.explinationLabel2.Location = new System.Drawing.Point(58, 88);
            this.explinationLabel2.Name = "explinationLabel2";
            this.explinationLabel2.Size = new System.Drawing.Size(100, 44);
            this.explinationLabel2.TabIndex = 5;
            this.explinationLabel2.Text = "Use WASD to move and 1 to shoot";
            this.explinationLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // explinationLabel1
            // 
            this.explinationLabel1.ForeColor = System.Drawing.Color.White;
            this.explinationLabel1.Location = new System.Drawing.Point(403, 32);
            this.explinationLabel1.Name = "explinationLabel1";
            this.explinationLabel1.Size = new System.Drawing.Size(185, 23);
            this.explinationLabel1.TabIndex = 6;
            this.explinationLabel1.Text = "PLAYER 2";
            this.explinationLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // explinationLabel3
            // 
            this.explinationLabel3.ForeColor = System.Drawing.Color.White;
            this.explinationLabel3.Location = new System.Drawing.Point(445, 88);
            this.explinationLabel3.Name = "explinationLabel3";
            this.explinationLabel3.Size = new System.Drawing.Size(100, 44);
            this.explinationLabel3.TabIndex = 7;
            this.explinationLabel3.Text = "Use arrows to move and M to shoot";
            this.explinationLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boostLabel
            // 
            this.boostLabel.BackColor = System.Drawing.Color.Red;
            this.boostLabel.Location = new System.Drawing.Point(235, 279);
            this.boostLabel.Name = "boostLabel";
            this.boostLabel.Size = new System.Drawing.Size(10, 10);
            this.boostLabel.TabIndex = 8;
            // 
            // boostLabel1
            // 
            this.boostLabel1.BackColor = System.Drawing.Color.Yellow;
            this.boostLabel1.Location = new System.Drawing.Point(235, 239);
            this.boostLabel1.Name = "boostLabel1";
            this.boostLabel1.Size = new System.Drawing.Size(10, 10);
            this.boostLabel1.TabIndex = 9;
            // 
            // explinationLabel5
            // 
            this.explinationLabel5.BackColor = System.Drawing.Color.Transparent;
            this.explinationLabel5.ForeColor = System.Drawing.Color.White;
            this.explinationLabel5.Location = new System.Drawing.Point(264, 232);
            this.explinationLabel5.Name = "explinationLabel5";
            this.explinationLabel5.Size = new System.Drawing.Size(73, 23);
            this.explinationLabel5.TabIndex = 10;
            this.explinationLabel5.Text = "Speed Boost";
            this.explinationLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // explinationLabel4
            // 
            this.explinationLabel4.BackColor = System.Drawing.Color.Transparent;
            this.explinationLabel4.ForeColor = System.Drawing.Color.White;
            this.explinationLabel4.Location = new System.Drawing.Point(264, 274);
            this.explinationLabel4.Name = "explinationLabel4";
            this.explinationLabel4.Size = new System.Drawing.Size(101, 23);
            this.explinationLabel4.TabIndex = 11;
            this.explinationLabel4.Text = "Pellet Speed Boost";
            this.explinationLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.explinationLabel4);
            this.Controls.Add(this.explinationLabel5);
            this.Controls.Add(this.boostLabel1);
            this.Controls.Add(this.boostLabel);
            this.Controls.Add(this.explinationLabel3);
            this.Controls.Add(this.explinationLabel1);
            this.Controls.Add(this.explinationLabel2);
            this.Controls.Add(this.explinationLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "gunnerForm";
            this.Text = "Gunner";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gunnerForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gunnerForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gunnerForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label screen;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label explinationLabel;
        private System.Windows.Forms.Label explinationLabel2;
        private System.Windows.Forms.Label explinationLabel1;
        private System.Windows.Forms.Label explinationLabel3;
        private System.Windows.Forms.Label boostLabel;
        private System.Windows.Forms.Label boostLabel1;
        private System.Windows.Forms.Label explinationLabel5;
        private System.Windows.Forms.Label explinationLabel4;
    }
}

