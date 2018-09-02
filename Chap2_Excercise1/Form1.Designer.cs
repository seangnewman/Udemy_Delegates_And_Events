namespace Chap2_Excercise1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelphi = new System.Windows.Forms.RadioButton();
            this.rbPython = new System.Windows.Forms.RadioButton();
            this.rbCPlusPlus = new System.Windows.Forms.RadioButton();
            this.rbJavaScript = new System.Windows.Forms.RadioButton();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbCSharp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelphi);
            this.groupBox1.Controls.Add(this.rbPython);
            this.groupBox1.Controls.Add(this.rbCPlusPlus);
            this.groupBox1.Controls.Add(this.rbJavaScript);
            this.groupBox1.Controls.Add(this.rbJava);
            this.groupBox1.Controls.Add(this.rbCSharp);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferred Languages";
            // 
            // rbDelphi
            // 
            this.rbDelphi.AutoSize = true;
            this.rbDelphi.Location = new System.Drawing.Point(18, 147);
            this.rbDelphi.Name = "rbDelphi";
            this.rbDelphi.Size = new System.Drawing.Size(55, 17);
            this.rbDelphi.TabIndex = 5;
            this.rbDelphi.Text = "Delphi";
            this.rbDelphi.UseVisualStyleBackColor = true;
            this.rbDelphi.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // rbPython
            // 
            this.rbPython.AutoSize = true;
            this.rbPython.Location = new System.Drawing.Point(18, 124);
            this.rbPython.Name = "rbPython";
            this.rbPython.Size = new System.Drawing.Size(58, 17);
            this.rbPython.TabIndex = 4;
            this.rbPython.Text = "Python";
            this.rbPython.UseVisualStyleBackColor = true;
            this.rbPython.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // rbCPlusPlus
            // 
            this.rbCPlusPlus.AutoSize = true;
            this.rbCPlusPlus.Location = new System.Drawing.Point(18, 101);
            this.rbCPlusPlus.Name = "rbCPlusPlus";
            this.rbCPlusPlus.Size = new System.Drawing.Size(44, 17);
            this.rbCPlusPlus.TabIndex = 3;
            this.rbCPlusPlus.Text = "C++";
            this.rbCPlusPlus.UseVisualStyleBackColor = true;
            this.rbCPlusPlus.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // rbJavaScript
            // 
            this.rbJavaScript.AutoSize = true;
            this.rbJavaScript.Location = new System.Drawing.Point(18, 78);
            this.rbJavaScript.Name = "rbJavaScript";
            this.rbJavaScript.Size = new System.Drawing.Size(75, 17);
            this.rbJavaScript.TabIndex = 2;
            this.rbJavaScript.Text = "JavaScript";
            this.rbJavaScript.UseVisualStyleBackColor = true;
            this.rbJavaScript.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(18, 55);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(48, 17);
            this.rbJava.TabIndex = 1;
            this.rbJava.Text = "Java";
            this.rbJava.UseVisualStyleBackColor = true;
            this.rbJava.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // rbCSharp
            // 
            this.rbCSharp.AutoSize = true;
            this.rbCSharp.Checked = true;
            this.rbCSharp.Location = new System.Drawing.Point(18, 32);
            this.rbCSharp.Name = "rbCSharp";
            this.rbCSharp.Size = new System.Drawing.Size(39, 17);
            this.rbCSharp.TabIndex = 0;
            this.rbCSharp.TabStop = true;
            this.rbCSharp.Text = "C#";
            this.rbCSharp.UseVisualStyleBackColor = true;
            this.rbCSharp.Click += new System.EventHandler(this.rbLanguages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chap2 Defining Delegate Exercise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCSharp;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbDelphi;
        private System.Windows.Forms.RadioButton rbPython;
        private System.Windows.Forms.RadioButton rbCPlusPlus;
        private System.Windows.Forms.RadioButton rbJavaScript;
    }
}

