using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestOneYet
{

    public partial class Form1 : Form
    {
        int score = 0;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && this.AcceptButton == null)
            {
                TextBoxBase box = this.ActiveControl as TextBoxBase;
                if (box == null || !box.Multiline)
                {
                    // Not a dialog, not a multi-line textbox; we can use Enter for tabbing
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public static string passingUsername;
        public Form1()
        {
            InitializeComponent();
        }
        int num01, num02, num03, num04;
        private void Form1_Load(object sender, EventArgs e)
        {
            nameTxtbox.Select();

        }

        private void nameEnterBTN_Click(object sender, EventArgs e)
        {
            leftsidePanel.Visible = true;
            mainmenuTxtbox.Visible = true;
            nameTxtbox.Visible = false;
            nameEnterBTN.Visible = false;
            helloLabel.Visible = true;
            mathiqLabel.Visible = true;
            score.ToString();
            mathiqLabel.Text = score.ToString();
            passingUsername = nameTxtbox.Text;
            helloLabel.Text = "Hello, " + Form1.passingUsername;
            mathiqLabel.Text = "You Math IQ is: " + score;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainmenuTxtbox.Visible = false;
            nEquationBox.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Random random = new System.Random();

            int min = 5;
            int max = 15;
            num01 = random.Next(min / 2, max / 2) * 2;
            num1.Text = num01.ToString();


            int m = 2;
            int n = 6;
            num02 = random.Next(m / 2, n / 2) * 2;
            num2.Text = num02.ToString();

            num03 = random.Next(1, 10);
            label4.Text = num03.ToString();

            num04 = random.Next(5);
            label5.Text = num04.ToString();

        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            int answer1 = Convert.ToInt32(answerTextbox.Text);
            int answer2 = Convert.ToInt32(textBox2.Text);

            if (((num01 + num02) == answer1) && ((num03 + num04) == answer2))
            {
                answerLabel.ForeColor = Color.Green;
                answerLabel.Text = "Well done! + Math IQ";
                score.ToString();
                mathiqLabel.Text = "Your math IQ is: " +score;
                score.ToString();
                score = +2;
            }
            else
            {
                answerLabel.ForeColor = Color.Red;
                answerLabel.Text = "Try again, you can do it!" + "- Math IQ";
                score.ToString();
                mathiqLabel.Text = "Your math IQ is: " +score;
                score.ToString();
                mathiqLabel.Text = score.ToString();
                score = -1;
            }

        }

    }
}


