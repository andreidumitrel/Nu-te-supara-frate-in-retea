namespace Nu_te_supara_frate
{
    partial class Login
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
            this.exitButton = new System.Windows.Forms.Button();
            this.labelPornire = new System.Windows.Forms.Label();
            this.labelNumeJucator = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(528, 327);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 24);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // labelPornire
            // 
            this.labelPornire.AutoSize = true;
            this.labelPornire.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPornire.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelPornire.Location = new System.Drawing.Point(174, 24);
            this.labelPornire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPornire.Name = "labelPornire";
            this.labelPornire.Size = new System.Drawing.Size(278, 34);
            this.labelPornire.TabIndex = 1;
            this.labelPornire.Text = "Nu te supăra frate";
            // 
            // labelNumeJucator
            // 
            this.labelNumeJucator.AutoSize = true;
            this.labelNumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeJucator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumeJucator.Location = new System.Drawing.Point(134, 168);
            this.labelNumeJucator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeJucator.Name = "labelNumeJucator";
            this.labelNumeJucator.Size = new System.Drawing.Size(171, 24);
            this.labelNumeJucator.TabIndex = 2;
            this.labelNumeJucator.Text = "Introduceți numele:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(302, 174);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(152, 20);
            this.textBoxNume.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(235, 243);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(146, 56);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_click);
            this.buttonStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterButtonDown);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.BackColor = System.Drawing.Color.Transparent;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClient.Location = new System.Drawing.Point(440, 50);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(38, 13);
            this.labelClient.TabIndex = 5;
            this.labelClient.Text = "client";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(138, 337);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIP.Size = new System.Drawing.Size(119, 20);
            this.textBoxIP.TabIndex = 6;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIP.Location = new System.Drawing.Point(17, 336);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(122, 18);
            this.labelIP.TabIndex = 7;
            this.labelIP.Text = "Adresa IP Server:";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNumeJucator);
            this.Controls.Add(this.labelPornire);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Nu te supara frate - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelPornire;
        private System.Windows.Forms.Label labelNumeJucator;
        private System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelIP;
        public System.Windows.Forms.TextBox textBoxIP;
    }
}

