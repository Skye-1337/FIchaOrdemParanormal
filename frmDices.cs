using MongoDB.Driver.Core.Operations;
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
    public partial class frmDices : Form
    {
        public frmDices()
        {
            InitializeComponent();
        }

        private readonly List<int> list = new List<int>();
        #region MyDeclaration
        private void GenerateDices(int dices, int sides, int mod)
        {
            Random rnd = new Random();
            list.Clear();
            sides++;

            for (int _ = 0; _ < dices; _++)
            {
                int n = rnd.Next(1, sides);
                list.Add(n);
            }
            PrintDices(mod);
        }

        private void PrintDices(int mod)
        {
            string result = "Resultado: ";
            foreach (var item in list)
            {
                result += $"{item}, ";
            }
            lbResult.Text = result;

            lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 2, 2);

            if (mod > 0) lbTotal.Text = $"Total: {list.Sum()} + {mod} = {list.Sum() + mod}";
            else lbTotal.Text = $"Total: {list.Sum()}";

            if (mod > 0) lbHigher.Text = $"Maior número: {list.Max()} + {mod} = {list.Max() + mod}";
            else lbHigher.Text = $"Maior número: {list.Max()}";
        }
        #endregion

        private void CheckedChanged(object sender, EventArgs e)
        {
            int dices;
            try { dices = Convert.ToInt32(txtSpeedDices.Text); }
            catch { return; }

            int mod;
            try { mod = Convert.ToInt32(txtSpeedMod.Text); }
            catch { mod = 0; }

            if (rbtnD3.Checked) GenerateDices(dices, 3, mod);
            else if (rbtnD4.Checked) GenerateDices(dices, 4, mod);
            else if (rbtnD6.Checked) GenerateDices(dices, 6, mod);
            else if (rbtnD8.Checked) GenerateDices(dices, 8, mod);
            else if (rbtnD10.Checked) GenerateDices(dices, 10, mod);
            else if (rbtnD12.Checked) GenerateDices(dices, 12, mod);
            else if (rbtnD20.Checked) GenerateDices(dices, 20, mod);
        }

        private void Dices_TextChanged(object sender, EventArgs e)
        {
            int dices, sides;
            try
            {
                dices = Convert.ToInt32(txtDices.Text);
                sides = Convert.ToInt32(txtSides.Text);
            }
            catch { return; }

            GenerateDices(dices, sides, 0);
        }

        private void SpeedDices_TextChanged(object sender, EventArgs e)
        {
            int mod, dices;
            try { dices = Convert.ToInt32(txtSpeedDices.Text); }
            catch
            {
                MessageBox.Show("Texto inserido enves de números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try { mod = Convert.ToInt32(txtSpeedMod.Text); }
            catch { mod = 0; }

            if (rbtnD3.Checked) GenerateDices(dices, 3, mod);
            else if (rbtnD4.Checked) GenerateDices(dices, 4, mod);
            else if (rbtnD6.Checked) GenerateDices(dices, 6, mod);
            else if (rbtnD8.Checked) GenerateDices(dices, 8, mod);
            else if (rbtnD10.Checked) GenerateDices(dices, 10, mod);
            else if (rbtnD12.Checked) GenerateDices(dices, 12, mod);
            else if (rbtnD20.Checked) GenerateDices(dices, 20, mod);
        }

        private void txtMod_TextChanged(object sender, EventArgs e)
        {
            int mod;
            try { mod = Convert.ToInt32(txtMod.Text); }
            catch { return; }
            PrintDices(mod);
        }
    }
}
