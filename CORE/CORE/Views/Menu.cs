using CORE.Properties;
using CORE.Views.Fabricante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE.Views
{
    public partial class Menu : Form
    {
        bool estado = false;
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

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Fornecedor.Cad_Fornecedor vcadfornecedor = new Views.Fornecedor.Cad_Fornecedor();
            vcadfornecedor.MdiParent = this;
            vcadfornecedor.Show();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.Fabricante.Cad_Fabricante vcadfabricante = new Views.Fabricante.Cad_Fabricante();
            vcadfabricante.MdiParent = this;
            vcadfabricante.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (estado == false)
            {
                pnl_cadastros.Height += 20;
                if (pnl_cadastros.Size == pnl_cadastros.MaximumSize)
                {
                    timer1.Stop();
                    estado = true;
                    button1.Image = Resources.Collapse_Arrow_20px;
                }

            }
            else
            {
                pnl_cadastros.Height -= 20;
                if (pnl_cadastros.Size == pnl_cadastros.MinimumSize)
                {
                    timer1.Stop();
                    estado = false;
                    button1.Image = Resources.Expand_Arrow_20px;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
