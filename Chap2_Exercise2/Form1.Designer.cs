namespace Chap2_Exercise2
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
            this.lblMovies = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.adjustGrossButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(34, 30);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(84, 17);
            this.lblMovies.TabIndex = 1;
            this.lblMovies.Text = "Favorite Movies";
            this.lblMovies.UseCompatibleTextRendering = true;
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(34, 59);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(618, 108);
            this.moviesListBox.TabIndex = 2;
            // 
            // adjustGrossButton
            // 
            this.adjustGrossButton.Location = new System.Drawing.Point(34, 200);
            this.adjustGrossButton.Name = "adjustGrossButton";
            this.adjustGrossButton.Size = new System.Drawing.Size(75, 23);
            this.adjustGrossButton.TabIndex = 3;
            this.adjustGrossButton.Text = "Adjust Gross";
            this.adjustGrossButton.UseVisualStyleBackColor = true;
            this.adjustGrossButton.Click += new System.EventHandler(this.adjustGrossButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 261);
            this.Controls.Add(this.adjustGrossButton);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.lblMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Button adjustGrossButton;
    }
}

