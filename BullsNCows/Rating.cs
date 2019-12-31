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
    public partial class Rating : MaterialSkin.Controls.MaterialForm
    {
        Controller controller;
        public Rating()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            Program.Parent.Hide();
            RatingGridView.DataSource = controller.GetGames(true);
        }

        private void Rating_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Parent.Show();
        }
    }
}
