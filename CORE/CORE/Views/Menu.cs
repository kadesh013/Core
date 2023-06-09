using CORE.Views.Fabricante;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            Views.Fornecedor.Cad_Fornecedor cadfornecedor = new Views.Fornecedor.Cad_Fornecedor();
            this.Hide();
            cadfornecedor.Show();
        }

        private void btn_fabricantes_Click(object sender, EventArgs e)
        {
            Views.Fabricante.Cad_Fabricante cadfabricante = new Views.Fabricante.Cad_Fabricante();
            this.Hide();
            cadfabricante.Show();
        }
    }
}
