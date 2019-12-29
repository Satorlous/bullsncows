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
        public LoadWindow()
        {
            InitializeComponent();
        }

        private void LoadWindow_Load(object sender, EventArgs e)
        {
            Program.Parent.Hide();
        }

        private void LoadWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Parent.Show();
        }
    }
}
