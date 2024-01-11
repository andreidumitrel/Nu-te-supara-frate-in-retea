namespace Nu_te_supara_frate
{
    partial class FereastraCastig
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
            this.pictureBoxCastig = new System.Windows.Forms.PictureBox();
            this.labelCastigator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastig)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCastig
            // 
            this.pictureBoxCastig.BackgroundImage = global::Nu_te_supara_frate.Properties.Resources.trofeuCastig;
            this.pictureBoxCastig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCastig.Location = new System.Drawing.Point(141, 12);
            this.pictureBoxCastig.Name = "pictureBoxCastig";
            this.pictureBoxCastig.Size = new System.Drawing.Size(351, 245);
            this.pictureBoxCastig.TabIndex = 0;
            this.pictureBoxCastig.TabStop = false;
            // 
            // labelCastigator
            // 
            this.labelCastigator.AutoSize = true;
            this.labelCastigator.BackColor = System.Drawing.Color.Transparent;
            this.labelCastigator.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCastigator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCastigator.Location = new System.Drawing.Point(96, 310);
            this.labelCastigator.Name = "labelCastigator";
            this.labelCastigator.Size = new System.Drawing.Size(453, 46);
            this.labelCastigator.TabIndex = 1;
            this.labelCastigator.Text = "Jucatorul a castigat!";
            // 
            // FereastraCastig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(626, 463);
            this.Controls.Add(this.labelCastigator);
            this.Controls.Add(this.pictureBoxCastig);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FereastraCastig";
            this.Text = "FereastraCastig";
            this.Load += new System.EventHandler(this.FereastraCastig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCastig;
        private System.Windows.Forms.Label labelCastigator;
    }
}