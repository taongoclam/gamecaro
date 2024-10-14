namespace Gamecaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlchessboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctbavtar = new System.Windows.Forms.PictureBox();
            this.txbplayername = new System.Windows.Forms.TextBox();
            this.prcbcooldown = new System.Windows.Forms.ProgressBar();
            this.pctbmark = new System.Windows.Forms.PictureBox();
            this.txbip = new System.Windows.Forms.TextBox();
            this.btnlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbavtar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbmark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlchessboard
            // 
            this.pnlchessboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlchessboard.Location = new System.Drawing.Point(24, 12);
            this.pnlchessboard.Name = "pnlchessboard";
            this.pnlchessboard.Size = new System.Drawing.Size(966, 960);
            this.pnlchessboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctbavtar);
            this.panel2.Location = new System.Drawing.Point(1022, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 464);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnlan);
            this.panel3.Controls.Add(this.txbip);
            this.panel3.Controls.Add(this.pctbmark);
            this.panel3.Controls.Add(this.prcbcooldown);
            this.panel3.Controls.Add(this.txbplayername);
            this.panel3.Location = new System.Drawing.Point(1022, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 493);
            this.panel3.TabIndex = 2;
            // 
            // pctbavtar
            // 
            this.pctbavtar.BackColor = System.Drawing.SystemColors.Control;
            this.pctbavtar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbavtar.Image = global::Gamecaro.Properties.Resources.caro;
            this.pctbavtar.Location = new System.Drawing.Point(3, 6);
            this.pctbavtar.Name = "pctbavtar";
            this.pctbavtar.Size = new System.Drawing.Size(582, 455);
            this.pctbavtar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbavtar.TabIndex = 0;
            this.pctbavtar.TabStop = false;
            // 
            // txbplayername
            // 
            this.txbplayername.Location = new System.Drawing.Point(0, 3);
            this.txbplayername.Multiline = true;
            this.txbplayername.Name = "txbplayername";
            this.txbplayername.ReadOnly = true;
            this.txbplayername.Size = new System.Drawing.Size(275, 64);
            this.txbplayername.TabIndex = 0;
            // 
            // prcbcooldown
            // 
            this.prcbcooldown.Location = new System.Drawing.Point(3, 73);
            this.prcbcooldown.Name = "prcbcooldown";
            this.prcbcooldown.Size = new System.Drawing.Size(272, 61);
            this.prcbcooldown.TabIndex = 1;
            // 
            // pctbmark
            // 
            this.pctbmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbmark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctbmark.Location = new System.Drawing.Point(301, 3);
            this.pctbmark.Name = "pctbmark";
            this.pctbmark.Size = new System.Drawing.Size(287, 260);
            this.pctbmark.TabIndex = 2;
            this.pctbmark.TabStop = false;
            // 
            // txbip
            // 
            this.txbip.Location = new System.Drawing.Point(0, 140);
            this.txbip.Multiline = true;
            this.txbip.Name = "txbip";
            this.txbip.Size = new System.Drawing.Size(275, 61);
            this.txbip.TabIndex = 3;
            // 
            // btnlan
            // 
            this.btnlan.Location = new System.Drawing.Point(0, 207);
            this.btnlan.Name = "btnlan";
            this.btnlan.Size = new System.Drawing.Size(275, 56);
            this.btnlan.TabIndex = 4;
            this.btnlan.Text = "button1";
            this.btnlan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 984);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlchessboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbavtar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbmark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlchessboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctbavtar;
        private System.Windows.Forms.PictureBox pctbmark;
        private System.Windows.Forms.TextBox txbplayername;
        private System.Windows.Forms.Button btnlan;
        private System.Windows.Forms.TextBox txbip;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ProgressBar prcbcooldown;
    }
}

