using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptPW
{
    public partial class EncryptPW : Form
    {
        public EncryptPW()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strOutput = string.Empty;
            txtResult.Text = string.Empty;

            EncryptionMgr encryptionMgr = new EncryptionMgr();

            if (rbEncrypt.Checked == true)
                strOutput = encryptionMgr.Encrypt(txtInput.Text);
            else
                strOutput = encryptionMgr.Decrypt(txtInput.Text);                       

            txtResult.Text = strOutput;
        }
    }
}
