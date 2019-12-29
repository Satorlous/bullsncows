using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsNCows
{
    public partial class GameWindow : MaterialSkin.Controls.MaterialForm
    {
        public int[] number;
        public bool[] cow;
        public bool[] bull;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            Program.Parent.Hide();
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Parent.Visible = true;
        }

        private void InputTextBox_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyData == Keys.Enter)
            {
                if (int.TryParse(inputTextBox.Text, out int inputNumber) && inputNumber.ToString().Length == 4)
                {
                    inputTextBox.Clear();
                    inputListBox.Items.Insert(0, inputNumber);
                }
                else
                {
                    inputTextBox.Clear();
                }
            }
        }
    }
}
