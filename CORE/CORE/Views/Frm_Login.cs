using CORE.Controllers;
using CORE.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE.Views
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            Controllers.Login log = new Controllers.Login();
            log.Username = txt_user.Text;
            log.Password = txt_password.Text;

            if (log.Logar() == true)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha errados.");
            }

        }
        private void btn_sair_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
