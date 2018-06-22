namespace GeniusGame
{
    partial class FormMain
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(47, 19);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(224, 73);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Novo jogo";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonRanking
            // 
            this.buttonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.ForeColor = System.Drawing.Color.White;
            this.buttonRanking.Location = new System.Drawing.Point(47, 96);
            this.buttonRanking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(224, 73);
            this.buttonRanking.TabIndex = 1;
            this.buttonRanking.Text = "Ranking";
            this.buttonRanking.UseVisualStyleBackColor = true;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(323, 189);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonNewGame);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonRanking;
    }
}

