using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2_Excercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private delegate void progLanguageMethod();

        private void rbLanguages_Click(object sender, EventArgs e)
        {
            progLanguageMethod langChoice = null;

            
            if (sender == rbCSharp) {
                langChoice = languageCSharp;
            }else if (sender == rbJava)
            {
                langChoice = languageJava;
            }else if (sender == rbJavaScript)
            {
                langChoice = languageJavaScript;
            }else if (sender == rbPython)
            {
                langChoice = languagePython;
            }else if (sender == rbCPlusPlus)
            {
                langChoice = languageCPlusPlus;
            }else
            {
                langChoice = languageDelphi;
            }

            langChoice();
        }

        private void languageCSharp()
        {
            MessageBox.Show("Let's Get Certified!");
        }

        private void languageJava()
        {
            MessageBox.Show("Continue development");
        }

        private void languageJavaScript()
        {
            MessageBox.Show("Continue development in frameworks and SPA");
        }

        private void languageCPlusPlus()
        {
            MessageBox.Show("Learn through Game Development");
        }

        private void languagePython()
        {
            MessageBox.Show("Rasperry Pi and Machine Learning");
        }

        private void languageDelphi()
        {
            MessageBox.Show("Niche programming");
        }
    }
}
