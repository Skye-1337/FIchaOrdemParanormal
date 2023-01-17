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
    public partial class frmAlterInfo : Form
    {
        public frmAlterInfo(string item = "", int value = 0)
        {
            InitializeComponent();
            init(item, value);
        }
        #region MyDeclarations

        private void init(string item, int value)
        {
            Text = $"Alterando {item}"; // ?
            lbTitulo.Text = "{item} {item value} atual";
            lbInfo.Text = $"Alterando {item}";
        }

        #endregion

    }
}
