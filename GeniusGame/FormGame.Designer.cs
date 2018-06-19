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
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(3, 315);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(318, 309);
            this.buttonRed.TabIndex = 2;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(325, 0);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(318, 309);
            this.buttonYellow.TabIndex = 3;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(3, 0);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(318, 309);
            this.buttonGreen.TabIndex = 4;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Navy;
            this.buttonBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBlue.FlatAppearance.BorderSize = 0;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(325, 315);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(318, 309);
            this.buttonBlue.TabIndex = 1;
            this.buttonBlue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBlue);
            this.panel1.Controls.Add(this.buttonRed);
            this.panel1.Controls.Add(this.buttonGreen);
            this.panel1.Controls.Add(this.buttonYellow);
            this.panel1.Location = new System.Drawing.Point(39, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 628);
            this.panel1.TabIndex = 5;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.button2);
            this.panelControls.Controls.Add(this.buttonConfiguration);
            this.panelControls.Location = new System.Drawing.Point(42, 27);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(316, 129);
            this.panelControls.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.BackColor = System.Drawing.Color.Black;
            this.buttonConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguration.Location = new System.Drawing.Point(0, 0);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(316, 64);
            this.buttonConfiguration.TabIndex = 0;
            this.buttonConfiguration.Text = "Configurações";
            this.buttonConfiguration.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(721, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.panel1.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Label label1;
    }
}