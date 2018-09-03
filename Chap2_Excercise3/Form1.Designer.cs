namespace Chap2_Excercise3
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
            this.favoriteMovieLabel = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.adjustGrossButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // favoriteMovieLabel
            // 
            this.favoriteMovieLabel.AutoSize = true;
            this.favoriteMovieLabel.Location = new System.Drawing.Point(23, 13);
            this.favoriteMovieLabel.Name = "favoriteMovieLabel";
            this.favoriteMovieLabel.Size = new System.Drawing.Size(82, 13);
            this.favoriteMovieLabel.TabIndex = 0;
            this.favoriteMovieLabel.Text = "Favorite Movies";
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(26, 43);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(493, 134);
            this.moviesListBox.TabIndex = 1;
            // 
            // adjustGrossButton
            // 
            this.adjustGrossButton.Location = new System.Drawing.Point(26, 200);
            this.adjustGrossButton.Name = "adjustGrossButton";
            this.adjustGrossButton.Size = new System.Drawing.Size(75, 23);
            this.adjustGrossButton.TabIndex = 2;
            this.adjustGrossButton.Text = "Adjust Gross";
            this.adjustGrossButton.UseVisualStyleBackColor = true;
            this.adjustGrossButton.Click += new System.EventHandler(this.adjustGrossButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.adjustGrossButton);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.favoriteMovieLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label favoriteMovieLabel;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Button adjustGrossButton;
    }
}

