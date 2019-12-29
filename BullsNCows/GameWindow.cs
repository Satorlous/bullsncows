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
        private List<string> history;
        public bool[] cow;
        public bool[] bull;
        private bool isTraining;
        Controller controller;

        public GameWindow(bool isTraining = false)
        {
            this.isTraining = isTraining;
            InitializeComponent();
            controller = new Controller();
            history = new List<string>();
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
            inputTextBox.Select();
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
                    var response = controller.CheckNumber(number);
                    if(response == null)
                    {
                        MessageBox.Show("Некоректные данные");
                        return;
                    }
                    int countBulls = response["Bulls"].Count(x => x == 1);
                    int countCows = response["Cows"].Count(x => x == 1);
                    bullCountLabel.Text = countBulls.ToString();
                    cowCountLabel.Text = countCows.ToString();
                    string item = string.Format("{0}. {1,-12:N10} Быков: {2}, Коров: {3}", inputListBox.Items.Count+1, number, countBulls, countCows);
                    inputListBox.Items.Insert(0, item);
                    history.Insert(0, number);

                    SetLastNumber(number);
                    if(countBulls == 4)
                    {
                        var title = "Поздравлем!";
                        var message = "Вы выйграли!";                       
                        DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
                inputTextBox.Clear();
            }
            if (history.Count > 0 && e.KeyData == Keys.Down)
            {
                int index = history.IndexOf(inputTextBox.Text);
                if(index == 0 || index == -1)
                {
                    index = history.Count;
                }
                inputTextBox.Text = history[index - 1];
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
            }
            if (history.Count > 0 && e.KeyData == Keys.Up)
            {
                int index = history.IndexOf(inputTextBox.Text);
                if (index == (history.Count - 1))
                {
                    index = -1;
                }
                inputTextBox.Text = history[index + 1];
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
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
