using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIchaOrdemParanormal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region My Declarations
        
        #endregion
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = Encryption.Encrypt(txtPassword.Text);
        }

    }
}
 