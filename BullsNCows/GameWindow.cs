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
        public string number;
        private List<string> history;
        public int[] cows;
        public int[] bulls;
        private bool isTraining;
        private bool isTipEnabled = false;
        Controller controller;
        List<Label> currentNumberLabels;

        public GameWindow(bool isTraining = false)
        {
            this.isTraining = isTraining;
            InitializeComponent();
            controller = new Controller();
            history = new List<string>();
            currentNumberLabels = new List<Label>();

        }

        private void GameWindow_Load(object sender, EventArgs e)
        {            
            Program.Parent.Hide();
            if (isTraining)
            {
                tipToggler.Show();                
                this.Text = "Обучение";
            }
            currentNumberLabels.Add(labelNum1);
            currentNumberLabels.Add(labelNum2);
            currentNumberLabels.Add(labelNum3);
            currentNumberLabels.Add(labelNum4);
            controller.StartGame("placeholder");
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
                string input = inputTextBox.Text.Trim();
                if (input.Length == 4)
                {
                    this.number = input;
                    var response = controller.CheckNumber(number);
                    if(response == null)
                    {
                        MessageBox.Show("Некоректные данные");
                        return;
                    }
                    lastNumberPanel.Show();
                    this.bulls = response["Bulls"];
                    this.cows = response["Cows"];
                    int countBulls = bulls.Count(x => x == 1);
                    int countCows = cows.Count(x => x == 1);
                    string item = string.Format("{0}. {1,-12:N10} Быков: {2}, Коров: {3}", inputListBox.Items.Count+1, number, countBulls, countCows);
                    inputListBox.Items.Insert(0, item);
                    history.Insert(0, number);
                    SetLastNumber(number);
                    if (isTraining && isTipEnabled)
                    {
                        ShowTip();
                    }
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

        private void ShowTip()
        {
            if (number != null)
            {
                foreach (var label in currentNumberLabels)
                {
                    var pos = currentNumberLabels.IndexOf(label);
                    var status = CheckMatch(pos);
                    if (status == "cow")
                        label.ForeColor = Color.Orange;
                    if (status == "bull")
                        label.ForeColor = Color.Green;
                    if (status == "blank")
                        label.ForeColor = Color.Black;
                }
            }
        }
        private void HideTip()
        {
            foreach (var label in currentNumberLabels)
            {
                label.ForeColor = Color.Black;
            }
        }

        private string CheckMatch(int pos)
        {
            if (cows[pos] == 1)
                return "cow";
            if (bulls[pos] == 1)
                return "bull";
            return "blank";
        }

        private void TipToggler_CheckedChanged(object sender, EventArgs e)
        {
            isTipEnabled = !isTipEnabled;            
            if (isTipEnabled)
                ShowTip();
            else
                HideTip();
        }
    }
}
