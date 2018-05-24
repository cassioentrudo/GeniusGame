namespace GeniusGame
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRed
            // 
            this.buttonRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRed.BackgroundImage")));
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(56, 275);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(277, 249);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYellow.BackgroundImage")));
            this.buttonYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(330, 32);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(277, 248);
            this.buttonYellow.TabIndex = 3;
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGreen.BackgroundImage")));
            this.buttonGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(56, 32);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(277, 248);
            this.buttonGreen.TabIndex = 4;
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBlue.BackgroundImage")));
            this.buttonBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBlue.FlatAppearance.BorderSize = 0;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(330, 275);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(277, 249);
            this.buttonBlue.TabIndex = 1;
            this.buttonBlue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRed);
            this.panel1.Controls.Add(this.buttonGreen);
            this.panel1.Controls.Add(this.buttonYellow);
            this.panel1.Controls.Add(this.buttonBlue);
            this.panel1.Location = new System.Drawing.Point(40, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 581);
            this.panel1.TabIndex = 5;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(955, 693);
            this.Controls.Add(this.panel1);
            this.Name = "FormGame";
            this.Text = "Game";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Panel panel1;
    }
}