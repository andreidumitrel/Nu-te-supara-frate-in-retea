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
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(704, 402);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(84, 29);
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
            this.labelPornire.Location = new System.Drawing.Point(232, 30);
            this.labelPornire.Name = "labelPornire";
            this.labelPornire.Size = new System.Drawing.Size(340, 43);
            this.labelPornire.TabIndex = 1;
            this.labelPornire.Text = "Nu te supăra frate";
            // 
            // labelNumeJucator
            // 
            this.labelNumeJucator.AutoSize = true;
            this.labelNumeJucator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeJucator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumeJucator.Location = new System.Drawing.Point(179, 207);
            this.labelNumeJucator.Name = "labelNumeJucator";
            this.labelNumeJucator.Size = new System.Drawing.Size(217, 29);
            this.labelNumeJucator.TabIndex = 2;
            this.labelNumeJucator.Text = "Introduceți numele:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(402, 214);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(201, 22);
            this.textBoxNume.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(313, 299);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(194, 69);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_click);
           // this.buttonStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterButtonDown);
            this.buttonStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterButtonDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNumeJucator);
            this.Controls.Add(this.labelPornire);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Nu te supara frate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelPornire;
        private System.Windows.Forms.Label labelNumeJucator;
        private System.Windows.Forms.Button buttonStart;
        public System.Windows.Forms.TextBox textBoxNume;
    }
}

