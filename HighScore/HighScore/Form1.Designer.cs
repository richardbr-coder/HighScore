namespace HighScore
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.Btnnewgame = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblletter = new System.Windows.Forms.Label();
            this.lbllscore = new System.Windows.Forms.Label();
            this.lblprescore = new System.Windows.Forms.Label();
            this.btnmatch = new System.Windows.Forms.Button();
            this.tbletter = new System.Windows.Forms.TextBox();
            this.tbscore = new System.Windows.Forms.TextBox();
            this.tbprescore = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.tbprescore);
            this.Panel1.Controls.Add(this.tbscore);
            this.Panel1.Controls.Add(this.tbletter);
            this.Panel1.Controls.Add(this.btnmatch);
            this.Panel1.Controls.Add(this.lblprescore);
            this.Panel1.Controls.Add(this.lbllscore);
            this.Panel1.Controls.Add(this.lblletter);
            this.Panel1.Controls.Add(this.btnexit);
            this.Panel1.Controls.Add(this.Btnnewgame);
            this.Panel1.Controls.Add(this.lblinfo);
            this.Panel1.Location = new System.Drawing.Point(24, 25);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(473, 414);
            this.Panel1.TabIndex = 0;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(167, 24);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(117, 13);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Enter A, B or C  to play!";
            // 
            // Btnnewgame
            // 
            this.Btnnewgame.Location = new System.Drawing.Point(65, 97);
            this.Btnnewgame.Name = "Btnnewgame";
            this.Btnnewgame.Size = new System.Drawing.Size(75, 23);
            this.Btnnewgame.TabIndex = 1;
            this.Btnnewgame.Text = "New Game";
            this.Btnnewgame.UseVisualStyleBackColor = true;
            this.Btnnewgame.Click += new System.EventHandler(this.Btnnewgame_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(159, 97);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblletter
            // 
            this.lblletter.AutoSize = true;
            this.lblletter.Location = new System.Drawing.Point(62, 159);
            this.lblletter.Name = "lblletter";
            this.lblletter.Size = new System.Drawing.Size(62, 13);
            this.lblletter.TabIndex = 3;
            this.lblletter.Text = "Enter Letter";
            // 
            // lbllscore
            // 
            this.lbllscore.AutoSize = true;
            this.lbllscore.Location = new System.Drawing.Point(62, 199);
            this.lbllscore.Name = "lbllscore";
            this.lbllscore.Size = new System.Drawing.Size(60, 13);
            this.lbllscore.TabIndex = 4;
            this.lbllscore.Text = "Your Score";
            // 
            // lblprescore
            // 
            this.lblprescore.AutoSize = true;
            this.lblprescore.Location = new System.Drawing.Point(43, 234);
            this.lblprescore.Name = "lblprescore";
            this.lblprescore.Size = new System.Drawing.Size(79, 13);
            this.lblprescore.TabIndex = 5;
            this.lblprescore.Text = "Previous Score";
            // 
            // btnmatch
            // 
            this.btnmatch.Location = new System.Drawing.Point(243, 154);
            this.btnmatch.Name = "btnmatch";
            this.btnmatch.Size = new System.Drawing.Size(75, 23);
            this.btnmatch.TabIndex = 6;
            this.btnmatch.Text = "Match Letter";
            this.btnmatch.UseVisualStyleBackColor = true;
            this.btnmatch.Click += new System.EventHandler(this.btnmatch_Click);
            // 
            // tbletter
            // 
            this.tbletter.Location = new System.Drawing.Point(137, 156);
            this.tbletter.Name = "tbletter";
            this.tbletter.Size = new System.Drawing.Size(100, 20);
            this.tbletter.TabIndex = 7;
            // 
            // tbscore
            // 
            this.tbscore.Location = new System.Drawing.Point(137, 192);
            this.tbscore.Name = "tbscore";
            this.tbscore.Size = new System.Drawing.Size(100, 20);
            this.tbscore.TabIndex = 8;
            // 
            // tbprescore
            // 
            this.tbprescore.Location = new System.Drawing.Point(137, 227);
            this.tbprescore.Name = "tbprescore";
            this.tbprescore.Size = new System.Drawing.Size(100, 20);
            this.tbprescore.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 467);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox tbprescore;
        private System.Windows.Forms.TextBox tbscore;
        private System.Windows.Forms.TextBox tbletter;
        private System.Windows.Forms.Button btnmatch;
        private System.Windows.Forms.Label lblprescore;
        private System.Windows.Forms.Label lbllscore;
        private System.Windows.Forms.Label lblletter;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button Btnnewgame;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

