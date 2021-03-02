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
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rowNumeric.Value * columnNumeric.Value < 18)
            {
                MessageBox.Show("Field is too small! You must have at-least 18 squares in the field....Please try again!");
                ((MainForm)this.Owner).custom = false;
            }
            else if (minesNumeric.Value > rowNumeric.Value * columnNumeric.Value / 2)
            {
                MessageBox.Show("Too many mines! At-most half of the squares in the field may have mines...Please try again!");
                ((MainForm)this.Owner).custom = false;
            }
            else
            {
                ((MainForm)this.Owner).customCol = (int)columnNumeric.Value;
                ((MainForm)this.Owner).customRow = (int)rowNumeric.Value;
                ((MainForm)this.Owner).customMine = (int)minesNumeric.Value;
                ((MainForm)this.Owner).custom = true;
               // ((MainForm)this.Owner).custom = true;
            }
        } 

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
