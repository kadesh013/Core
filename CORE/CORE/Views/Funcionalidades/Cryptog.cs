using CORE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE.Views.Funcionalidades
{
    public partial class Cryptog : Form
    {
        public Cryptog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cryptog_Load(object sender, EventArgs e)
        {

        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            try { 
            if (txt_criptografar.Text != "" && txt_chave.Text != "")
            {
                txt_resultado.Text = Criptografia.Crypto.DecryptStringAES(txt_criptografar.Text, txt_chave.Text);
                txt_resultado.Copy();
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("A chave não é valida para a descriptografia.");
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            try {
                if (txt_criptografar.Text != "" && txt_chave.Text != "")
                {
                    txt_resultado.Text = Criptografia.Crypto.EncryptStringAES(txt_criptografar.Text, txt_chave.Text);
                    txt_resultado.Copy();
                }
                else
                {
                    MessageBox.Show("Por favor preencha os campos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
