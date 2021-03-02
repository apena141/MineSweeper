using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        public int customRow, customCol, customMine;
        public bool custom = false;
        public int row = 0, col = 0, mines = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Play(object sender, EventArgs e)
        {
            //int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2         
            String text = "";
            Form2 f = null;
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            else if (customButton.Checked)
            {
                while (true)
                {
                    CustomForm cform = new CustomForm();
                    cform.Owner = this;
                    cform.ShowDialog();
                    //custom = false;

                    if (cform.DialogResult == DialogResult.OK && custom == true)
                    {
                        row = customRow;
                        mines = customMine;
                        col = customCol;
                        cform.Close();
                        break;
                    }
                    else if(cform.DialogResult == DialogResult.Cancel)
                    {
                        cform.Close();
                        custom = false;
                        break;
                    }
                   
                }
            }
            else
                return;
            if(customButton.Checked && custom == false)
            {
                return;
            }
            //if()
            // Need to skip this when cancel is selected during custom
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size,mines);
            f.Owner = this;
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAllGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
            {
                f.Close();
            }
        }

        private void toolStripenuItem1_Click(object sender, EventArgs e)
        {
            Play(sender, e);
        }

        private void customButton_Click(object sender, EventArgs e)
        {

        }

        private void endGamesButton_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.OwnedForms)
            {
                f.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void openGamesText_Click(object sender, EventArgs e)
        {

        }
    }
}
