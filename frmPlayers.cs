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
        private void alterInfo(string info, int value)
        {
            frmAlterInfo a = new frmAlterInfo(info);
            a.ShowDialog();
        }

        #endregion
        #region Altering Info
        private void lbVida_Click(object sender, EventArgs e)
        {
            // TODO
            // Get HP value and pass it to the form
            // Goto the database and get HP
            alterInfo("HP", 0);
        }
        private void lbDefesa_Click(object sender, EventArgs e)
        {
            alterInfo("Defesa", 0);
        }
        private void lbNEX_Click(object sender, EventArgs e)
        {
            alterInfo("NEX", 0);
        }
        private void lbPE_Click(object sender, EventArgs e)
        {
            alterInfo("PE", 0);
        }
        private void lbSanidade_Click(object sender, EventArgs e)
        {
            alterInfo("Sanidade", 0);
        }
        private void lbOrigem_Click(object sender, EventArgs e)
        {
            alterInfo("Origem", 0);
        }
        private void lbClasse_Click(object sender, EventArgs e)
        {
            alterInfo("Classe", 0);
        }
        private void lbDeslocamento_Click(object sender, EventArgs e)
        {
            alterInfo("Deslocamento", 0);
        }
        private void lbAgilidade_Click(object sender, EventArgs e)
        {
            alterInfo("Agilidade", 0);
        }
        private void lbForca_Click(object sender, EventArgs e)
        {
            alterInfo("Força", 0);
        }
        private void lbIntelecto_Click(object sender, EventArgs e)
        {
            alterInfo("Intelecto", 0);
        }
        private void lbPresenca_Click(object sender, EventArgs e)
        {
            alterInfo("Presença", 0);
        }
        private void lbVigor_Click(object sender, EventArgs e)
        {
            alterInfo("Vigor", 0);
        }
        #endregion

        private void btnRandomDices_Click(object sender, EventArgs e)
        {
            frmDices s = new frmDices();
            s.Show();
        }
    }
}
