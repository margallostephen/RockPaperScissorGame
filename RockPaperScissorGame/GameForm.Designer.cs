namespace RockPaperScissorGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.StartPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.PlayerHL = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerH5 = new System.Windows.Forms.Panel();
            this.PlayerH3 = new System.Windows.Forms.Panel();
            this.PlayerH1 = new System.Windows.Forms.Panel();
            this.PlayerH4 = new System.Windows.Forms.Panel();
            this.PlayerH2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComputerH1 = new System.Windows.Forms.Panel();
            this.ComputerH2 = new System.Windows.Forms.Panel();
            this.ComputerH3 = new System.Windows.Forms.Panel();
            this.ComputerH4 = new System.Windows.Forms.Panel();
            this.ComputerH5 = new System.Windows.Forms.Panel();
            this.ComputerHL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerPicBox = new System.Windows.Forms.PictureBox();
            this.ComputerPicBox = new System.Windows.Forms.PictureBox();
            this.RockBtn = new System.Windows.Forms.Button();
            this.ScissorBtn = new System.Windows.Forms.Button();
            this.PaperBtn = new System.Windows.Forms.Button();
            this.PickBtn = new System.Windows.Forms.Button();
            this.EndPanel = new System.Windows.Forms.Panel();
            this.EndPicBox = new System.Windows.Forms.PictureBox();
            this.PlayAgainBtn = new System.Windows.Forms.Button();
            this.StartPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicBox)).BeginInit();
            this.EndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.StartPanel.Controls.Add(this.GamePanel);
            this.StartPanel.Controls.Add(this.pictureBox3);
            this.StartPanel.Controls.Add(this.pictureBox2);
            this.StartPanel.Controls.Add(this.pictureBox1);
            this.StartPanel.Controls.Add(this.StartBtn);
            this.StartPanel.Controls.Add(this.InputName);
            this.StartPanel.Controls.Add(this.label2);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(1539, 897);
            this.StartPanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.White;
            this.GamePanel.BackgroundImage = global::RockPaperScissorGame.Resource.GameBackground;
            this.GamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamePanel.Controls.Add(this.EndPanel);
            this.GamePanel.Controls.Add(this.PickBtn);
            this.GamePanel.Controls.Add(this.PaperBtn);
            this.GamePanel.Controls.Add(this.ScissorBtn);
            this.GamePanel.Controls.Add(this.RockBtn);
            this.GamePanel.Controls.Add(this.ComputerPicBox);
            this.GamePanel.Controls.Add(this.PlayerPicBox);
            this.GamePanel.Controls.Add(this.flowLayoutPanel2);
            this.GamePanel.Controls.Add(this.ComputerHL);
            this.GamePanel.Controls.Add(this.label4);
            this.GamePanel.Controls.Add(this.flowLayoutPanel1);
            this.GamePanel.Controls.Add(this.PlayerHL);
            this.GamePanel.Controls.Add(this.PlayerName);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1539, 897);
            this.GamePanel.TabIndex = 9;
            // 
            // PlayerHL
            // 
            this.PlayerHL.BackColor = System.Drawing.Color.LimeGreen;
            this.PlayerHL.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerHL.Location = new System.Drawing.Point(734, 35);
            this.PlayerHL.Name = "PlayerHL";
            this.PlayerHL.Size = new System.Drawing.Size(178, 71);
            this.PlayerHL.TabIndex = 25;
            this.PlayerHL.Text = "100 HP";
            this.PlayerHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.LimeGreen;
            this.PlayerName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerName.Location = new System.Drawing.Point(39, 35);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(694, 71);
            this.PlayerName.TabIndex = 22;
            this.PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RockPaperScissorGame.Resource.ScissorsGif;
            this.pictureBox3.Location = new System.Drawing.Point(1028, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(547, 490);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RockPaperScissorGame.Resource.PaperGif;
            this.pictureBox2.Location = new System.Drawing.Point(543, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 490);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissorGame.Resource.RockGif;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(996, 314);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(193, 84);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Play";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputName
            // 
            this.InputName.BackColor = System.Drawing.Color.LimeGreen;
            this.InputName.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputName.ForeColor = System.Drawing.Color.Black;
            this.InputName.Location = new System.Drawing.Point(353, 319);
            this.InputName.MaxLength = 17;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(623, 75);
            this.InputName.TabIndex = 2;
            this.InputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(353, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(833, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Player Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 62F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1387, 155);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock Paper Scissors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.PlayerH5);
            this.flowLayoutPanel1.Controls.Add(this.PlayerH4);
            this.flowLayoutPanel1.Controls.Add(this.PlayerH3);
            this.flowLayoutPanel1.Controls.Add(this.PlayerH2);
            this.flowLayoutPanel1.Controls.Add(this.PlayerH1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(915, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 71);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // PlayerH5
            // 
            this.PlayerH5.BackgroundImage = global::RockPaperScissorGame.Resource.HeartBlack;
            this.PlayerH5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerH5.Location = new System.Drawing.Point(3, 3);
            this.PlayerH5.Name = "PlayerH5";
            this.PlayerH5.Size = new System.Drawing.Size(70, 65);
            this.PlayerH5.TabIndex = 29;
            // 
            // PlayerH3
            // 
            this.PlayerH3.BackgroundImage = global::RockPaperScissorGame.Resource.HeartBlack;
            this.PlayerH3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerH3.Location = new System.Drawing.Point(155, 3);
            this.PlayerH3.Name = "PlayerH3";
            this.PlayerH3.Size = new System.Drawing.Size(70, 65);
            this.PlayerH3.TabIndex = 29;
            // 
            // PlayerH1
            // 
            this.PlayerH1.BackgroundImage = global::RockPaperScissorGame.Resource.HeartBlack;
            this.PlayerH1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerH1.Location = new System.Drawing.Point(307, 3);
            this.PlayerH1.Name = "PlayerH1";
            this.PlayerH1.Size = new System.Drawing.Size(70, 65);
            this.PlayerH1.TabIndex = 29;
            // 
            // PlayerH4
            // 
            this.PlayerH4.BackgroundImage = global::RockPaperScissorGame.Resource.HeartBlack;
            this.PlayerH4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerH4.Location = new System.Drawing.Point(79, 3);
            this.PlayerH4.Name = "PlayerH4";
            this.PlayerH4.Size = new System.Drawing.Size(70, 65);
            this.PlayerH4.TabIndex = 29;
            // 
            // PlayerH2
            // 
            this.PlayerH2.BackgroundImage = global::RockPaperScissorGame.Resource.HeartBlack;
            this.PlayerH2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerH2.Location = new System.Drawing.Point(231, 3);
            this.PlayerH2.Name = "PlayerH2";
            this.PlayerH2.Size = new System.Drawing.Size(70, 65);
            this.PlayerH2.TabIndex = 29;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LimeGreen;
            this.flowLayoutPanel2.Controls.Add(this.ComputerH1);
            this.flowLayoutPanel2.Controls.Add(this.ComputerH2);
            this.flowLayoutPanel2.Controls.Add(this.ComputerH3);
            this.flowLayoutPanel2.Controls.Add(this.ComputerH4);
            this.flowLayoutPanel2.Controls.Add(this.ComputerH5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(247, 793);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(380, 71);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // ComputerH1
            // 
            this.ComputerH1.BackgroundImage = global::RockPaperScissorGame.Resource.HeartGreen;
            this.ComputerH1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerH1.Location = new System.Drawing.Point(3, 3);
            this.ComputerH1.Name = "ComputerH1";
            this.ComputerH1.Size = new System.Drawing.Size(70, 65);
            this.ComputerH1.TabIndex = 29;
            // 
            // ComputerH2
            // 
            this.ComputerH2.BackgroundImage = global::RockPaperScissorGame.Resource.HeartGreen;
            this.ComputerH2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerH2.Location = new System.Drawing.Point(79, 3);
            this.ComputerH2.Name = "ComputerH2";
            this.ComputerH2.Size = new System.Drawing.Size(70, 65);
            this.ComputerH2.TabIndex = 29;
            // 
            // ComputerH3
            // 
            this.ComputerH3.BackgroundImage = global::RockPaperScissorGame.Resource.HeartGreen;
            this.ComputerH3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerH3.Location = new System.Drawing.Point(155, 3);
            this.ComputerH3.Name = "ComputerH3";
            this.ComputerH3.Size = new System.Drawing.Size(70, 65);
            this.ComputerH3.TabIndex = 29;
            // 
            // ComputerH4
            // 
            this.ComputerH4.BackgroundImage = global::RockPaperScissorGame.Resource.HeartGreen;
            this.ComputerH4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerH4.Location = new System.Drawing.Point(231, 3);
            this.ComputerH4.Name = "ComputerH4";
            this.ComputerH4.Size = new System.Drawing.Size(70, 65);
            this.ComputerH4.TabIndex = 29;
            // 
            // ComputerH5
            // 
            this.ComputerH5.BackgroundImage = global::RockPaperScissorGame.Resource.HeartGreen;
            this.ComputerH5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerH5.Location = new System.Drawing.Point(307, 3);
            this.ComputerH5.Name = "ComputerH5";
            this.ComputerH5.Size = new System.Drawing.Size(70, 65);
            this.ComputerH5.TabIndex = 29;
            // 
            // ComputerHL
            // 
            this.ComputerHL.BackColor = System.Drawing.Color.Black;
            this.ComputerHL.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputerHL.ForeColor = System.Drawing.Color.LimeGreen;
            this.ComputerHL.Location = new System.Drawing.Point(630, 793);
            this.ComputerHL.Name = "ComputerHL";
            this.ComputerHL.Size = new System.Drawing.Size(178, 71);
            this.ComputerHL.TabIndex = 28;
            this.ComputerHL.Text = "100 HP";
            this.ComputerHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(809, 793);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 71);
            this.label4.TabIndex = 27;
            this.label4.Text = "Computer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerPicBox
            // 
            this.PlayerPicBox.BackColor = System.Drawing.Color.Black;
            this.PlayerPicBox.Location = new System.Drawing.Point(39, 132);
            this.PlayerPicBox.Name = "PlayerPicBox";
            this.PlayerPicBox.Size = new System.Drawing.Size(412, 458);
            this.PlayerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPicBox.TabIndex = 30;
            this.PlayerPicBox.TabStop = false;
            // 
            // ComputerPicBox
            // 
            this.ComputerPicBox.BackColor = System.Drawing.Color.LimeGreen;
            this.ComputerPicBox.Location = new System.Drawing.Point(1091, 313);
            this.ComputerPicBox.Name = "ComputerPicBox";
            this.ComputerPicBox.Size = new System.Drawing.Size(412, 458);
            this.ComputerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerPicBox.TabIndex = 31;
            this.ComputerPicBox.TabStop = false;
            // 
            // RockBtn
            // 
            this.RockBtn.AutoSize = true;
            this.RockBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RockBtn.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RockBtn.ForeColor = System.Drawing.Color.White;
            this.RockBtn.Location = new System.Drawing.Point(489, 132);
            this.RockBtn.Name = "RockBtn";
            this.RockBtn.Size = new System.Drawing.Size(171, 72);
            this.RockBtn.TabIndex = 32;
            this.RockBtn.Text = "Rock";
            this.RockBtn.UseVisualStyleBackColor = false;
            // 
            // ScissorBtn
            // 
            this.ScissorBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ScissorBtn.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScissorBtn.ForeColor = System.Drawing.Color.White;
            this.ScissorBtn.Location = new System.Drawing.Point(877, 132);
            this.ScissorBtn.Name = "ScissorBtn";
            this.ScissorBtn.Size = new System.Drawing.Size(206, 72);
            this.ScissorBtn.TabIndex = 33;
            this.ScissorBtn.Text = "Scissor";
            this.ScissorBtn.UseVisualStyleBackColor = false;
            this.ScissorBtn.Click += new System.EventHandler(this.ScissorBtn_Click);
            // 
            // PaperBtn
            // 
            this.PaperBtn.AutoSize = true;
            this.PaperBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.PaperBtn.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaperBtn.ForeColor = System.Drawing.Color.White;
            this.PaperBtn.Location = new System.Drawing.Point(683, 132);
            this.PaperBtn.Name = "PaperBtn";
            this.PaperBtn.Size = new System.Drawing.Size(171, 72);
            this.PaperBtn.TabIndex = 34;
            this.PaperBtn.Text = "Paper";
            this.PaperBtn.UseVisualStyleBackColor = false;
            this.PaperBtn.Click += new System.EventHandler(this.PaperBtn_Click);
            // 
            // PickBtn
            // 
            this.PickBtn.AutoSize = true;
            this.PickBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.PickBtn.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickBtn.ForeColor = System.Drawing.Color.White;
            this.PickBtn.Location = new System.Drawing.Point(683, 407);
            this.PickBtn.Name = "PickBtn";
            this.PickBtn.Size = new System.Drawing.Size(171, 79);
            this.PickBtn.TabIndex = 35;
            this.PickBtn.Text = "Pick";
            this.PickBtn.UseVisualStyleBackColor = false;
            this.PickBtn.Click += new System.EventHandler(this.PickBtn_Click);
            // 
            // EndPanel
            // 
            this.EndPanel.Controls.Add(this.PlayAgainBtn);
            this.EndPanel.Controls.Add(this.EndPicBox);
            this.EndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndPanel.Location = new System.Drawing.Point(0, 0);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(1539, 897);
            this.EndPanel.TabIndex = 0;
            // 
            // EndPicBox
            // 
            this.EndPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndPicBox.Location = new System.Drawing.Point(0, 0);
            this.EndPicBox.Name = "EndPicBox";
            this.EndPicBox.Size = new System.Drawing.Size(1539, 897);
            this.EndPicBox.TabIndex = 0;
            this.EndPicBox.TabStop = false;
            // 
            // PlayAgainBtn
            // 
            this.PlayAgainBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.PlayAgainBtn.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayAgainBtn.ForeColor = System.Drawing.Color.White;
            this.PlayAgainBtn.Location = new System.Drawing.Point(588, 621);
            this.PlayAgainBtn.Name = "PlayAgainBtn";
            this.PlayAgainBtn.Size = new System.Drawing.Size(363, 99);
            this.PlayAgainBtn.TabIndex = 1;
            this.PlayAgainBtn.Text = "Play Again";
            this.PlayAgainBtn.UseVisualStyleBackColor = false;
            this.PlayAgainBtn.Click += new System.EventHandler(this.PlayAgainBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 897);
            this.Controls.Add(this.StartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissor";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicBox)).EndInit();
            this.EndPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel StartPanel;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button StartBtn;
        private TextBox InputName;
        private Label label2;
        private Panel GamePanel;
        private Label PlayerHL;
        private Label PlayerName;
        private Panel PlayerH5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PlayerH2;
        private Panel PlayerH1;
        private Panel PlayerH4;
        private Panel PlayerH3;
        private PictureBox ComputerPicBox;
        private PictureBox PlayerPicBox;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel ComputerH1;
        private Panel ComputerH2;
        private Panel ComputerH3;
        private Panel ComputerH4;
        private Panel ComputerH5;
        private Label ComputerHL;
        private Label label4;
        private Button PickBtn;
        private Button PaperBtn;
        private Button ScissorBtn;
        private Button RockBtn;
        private Panel EndPanel;
        private Button PlayAgainBtn;
        private PictureBox EndPicBox;
    }
}