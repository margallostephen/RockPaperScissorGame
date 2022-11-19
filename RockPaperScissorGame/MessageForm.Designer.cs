namespace RockPaperScissorGame
{
    partial class MessageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MessagePic = new System.Windows.Forms.PictureBox();
            this.Message = new System.Windows.Forms.Label();
            this.MainBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 43);
            this.panel2.TabIndex = 1;
            // 
            // MessagePic
            // 
            this.MessagePic.Location = new System.Drawing.Point(29, 76);
            this.MessagePic.Name = "MessagePic";
            this.MessagePic.Size = new System.Drawing.Size(138, 136);
            this.MessagePic.TabIndex = 2;
            this.MessagePic.TabStop = false;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Message.Location = new System.Drawing.Point(195, 76);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(480, 107);
            this.Message.TabIndex = 3;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainBtn
            // 
            this.MainBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.MainBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainBtn.Location = new System.Drawing.Point(354, 218);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(160, 55);
            this.MainBtn.TabIndex = 4;
            this.MainBtn.Text = "Okay";
            this.MainBtn.UseVisualStyleBackColor = false;
            this.MainBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.Gold;
            this.YesBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YesBtn.Location = new System.Drawing.Point(215, 218);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(160, 55);
            this.YesBtn.TabIndex = 5;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.Crimson;
            this.NoBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoBtn.Location = new System.Drawing.Point(487, 218);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(160, 55);
            this.NoBtn.TabIndex = 6;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.MessagePic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            ((System.ComponentModel.ISupportInitialize)(this.MessagePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox MessagePic;
        private Label Message;
        private Button MainBtn;
        private Button YesBtn;
        private Button NoBtn;
    }
}