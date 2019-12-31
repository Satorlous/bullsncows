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
    public partial class LoadWindow : MaterialSkin.Controls.MaterialForm
    {
        public int IdGame;
        private string PlayerName { get; }
        public LoadWindow(string PlayerName)
        {
            InitializeComponent();
            this.PlayerName = PlayerName;
            IdGame = -1;
        }
        Controller controller;

        private void LoadWindow_Load(object sender, EventArgs e)
        {
            Program.Parent.Hide();
            this.Text += this.PlayerName;
            controller = new Controller();
            LoadGamesGridView.DataSource = controller.GetGames(false,this.PlayerName);
            LoadGamesGridView.Columns["Id"].Visible = false;
            LoadGamesGridView.Columns["Name"].HeaderText = "Игрок";
            LoadGamesGridView.Columns["DateTime"].HeaderText = "Дата игры";
            LoadGamesGridView.Columns["Score"].HeaderText = "Счет";
        }

        private void LoadWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Parent.Show();
        }

        /// <summary>
        /// Обработка нажатия кнопки в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGamesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                IdGame = int.Parse(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                this.Close();
            }
        }
    }
}
