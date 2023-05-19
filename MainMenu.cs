using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnDialogClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHrat_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();
        }
    }
}
