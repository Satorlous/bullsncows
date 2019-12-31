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
    public partial class Parent : MaterialSkin.Controls.MaterialForm
    {
        public Parent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parent_Load(object sender, EventArgs e)
        {
            Program.Parent = this;
        }

        /// <summary>
        /// Инициализация новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow(playerNameTextBox.Text, false);
            gameWindow.Show();
        }

        /// <summary>
        /// Загрузка существующей игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGame(object sender, EventArgs e)
        {
            LoadWindow loadWindow = new LoadWindow(playerNameTextBox.Text);
            loadWindow.Show();
            loadWindow.FormClosed += LoadWindow_FormClosed;
        }

        private void LoadWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loadWindow = (LoadWindow)sender;
            if(loadWindow.IdGame > -1)
            {
                GameWindow gameWindow = new GameWindow(playerNameTextBox.Text, false);
                gameWindow.IdGame = loadWindow.IdGame;
                gameWindow.Show();
            }
        }

        /// <summary>
        /// Инициализация новой тренировочной игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrainingGame(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow(playerNameTextBox.Text, true);
            gameWindow.Show();
        }

        private void ShowRating(object sender, EventArgs e)
        {
            Rating ratingWindow = new Rating();
            ratingWindow.Show();
        }
    }
}
