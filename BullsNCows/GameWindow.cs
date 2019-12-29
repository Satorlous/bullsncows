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
        private bool isTraining;
        Controller controller;

        public GameWindow(bool isTraining = false)
        {
            this.isTraining = isTraining;
            InitializeComponent();
            controller = new Controller();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {            
            Program.Parent.Hide();
            if (isTraining)
            {
                tipButton.Show();                
                this.Text = "Обучение";
            }
            controller.StartGame("ad");
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
                lastNumberPanel.Show();
                string number = inputTextBox.Text.Trim();
                if (number.Length == 4)
                {
                    inputListBox.Items.Insert(0, number);
                    var response = controller.CheckNumber(number);
                    int countBulls = response["Bulls"].Count(x => x == 1);
                    bullCountLabel.Text = countBulls.ToString();
                    cowCountLabel.Text = response["Cows"].Count(x => x == 1).ToString();
                    SetLastNumber(number);
                    if(countBulls == 4)
                    {
                        MessageBox.Show("Поздравлем! Вы выйграли!");
                    }
                }
                inputTextBox.Clear();
            }
            if (inputListBox.Items.Count > 0 && e.KeyData == Keys.Down)
            {
                int index = inputListBox.Items.IndexOf(inputTextBox.Text);
                if(index == 0 || index == -1)
                {
                    index = inputListBox.Items.Count;
                }
                inputTextBox.Text = inputListBox.Items[index - 1].ToString();
            }
            if (inputListBox.Items.Count > 0 && e.KeyData == Keys.Up)
            {
                int index = inputListBox.Items.IndexOf(inputTextBox.Text);
                if (index == (inputListBox.Items.Count - 1))
                {
                    index = -1;
                }
                inputTextBox.Text = inputListBox.Items[index + 1].ToString();
            }
        }

        private void SetLastNumber(string inputNumber)
        {
            labelNum1.Text = inputNumber[0].ToString();
            labelNum2.Text = inputNumber[1].ToString();
            labelNum3.Text = inputNumber[2].ToString();
            labelNum4.Text = inputNumber[3].ToString();
        }
    }
}
