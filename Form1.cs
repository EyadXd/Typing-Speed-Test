using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Test
{
    public partial class Form1 : Form
    {

        private int SecondsCounter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private double GetWPM()
        {
            string[] words = TbChallengeText.Text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return (double)(words.Length / ((double)SecondsCounter / 60));
        }

        private bool IsTextContains(string Container , string Cotainered)
        {
            if (string.IsNullOrEmpty(TbType.Text))
                return true;

            if (TbType.Text[TbType.Text.Length-1] == TbChallengeText.Text[TbType.Text.Length - 1])
                return true;

            else
                return false;
        }

        private void ChangeKeyboardColor(KeyPressEventArgs e , Color color)
        {
            foreach (Control cont in PnKeyboard.Controls)
            {
                if (cont.Text == e.KeyChar.ToString() || cont.Tag.ToString() == e.KeyChar.ToString())
                {
                    cont.BackColor = color;
                }
                else if (e.KeyChar == '\b')
                {
                    btnBackSpace.BackColor = color;
                }
            }
        }

        private async void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Change Key Color
            ChangeKeyboardColor(e, Color.Red); // Select Key
            await Task.Delay(300);
            ChangeKeyboardColor(e, Color.Silver); // DeSelect Key
            
            //Make Sure That Text Is Right


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Is Empty
            if(string.IsNullOrWhiteSpace(TbChallengeText.Text))
            {
                MessageBox.Show("Can't Make A Challenge With An Empty String","Empty String",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Set Lenght
            TbType.MaxLength = TbChallengeText.Text.Length;

            //Start Timer
            timer1.Start();

            //Disable Button && Challenge Text Box
            btnStart.Enabled = false;
            TbChallengeText.Enabled = false;

            //Enable Type Box && Done
            TbType.Enabled = true;
            btnDone.Enabled = true;


            //Foucus On Type
            TbType.Focus();

            //Defult Forme Button
            Form1.ActiveForm.AcceptButton = btnDone;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SecondsCounter++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TbType_TextChanged(object sender, EventArgs e)
        {
            if(!(IsTextContains(TbChallengeText.Text,TbType.Text)))
            {
                TbType.BackColor = Color.Red;
                TbType.MaxLength = TbType.Text.Length;
            }
            else
            {
                TbType.BackColor = Color.White;
                TbType.MaxLength = TbChallengeText.Text.Length;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        { 
            //Check Is Text Right
            if(TbType.Text != TbChallengeText.Text)
            {
                return;
            }
           
            //Stop Timer
            timer1.Stop();

            //Show Wpm
            MessageBox.Show(GetWPM().ToString() + " Word Per Minuit", "Your WPM");

            //Disable Button && Type
            btnDone.Enabled = false;
            TbType.Enabled = false;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear
            TbChallengeText.Clear();
            TbType.Clear();

            //Enable
            TbChallengeText.Enabled = true;
            btnStart.Enabled = true;
            
            //Reset
            SecondsCounter = 0;

            //Main Button
            Form1.ActiveForm.AcceptButton = btnStart;
        }
    }
}
