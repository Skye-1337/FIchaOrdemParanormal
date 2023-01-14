using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIchaOrdemParanormal
{
    public partial class frmPlayers : Form
    {
        public frmPlayers(string player = "{}")
        {
            InitializeComponent();
            init(player);
        }
        #region MyDeclaration
        private void init(string player)
        {
            Text = $"Player {player}";
        }


        #endregion

        private void lbVida_Click(object sender, EventArgs e)
        {
            // TODO
            // Get HP value and pass it to the form
            string hp = "";

            frmAlterInfo alter = new frmAlterInfo(hp);
            alter.ShowDialog();
        }
    }
}
