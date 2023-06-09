using CORE.Controllers;
using CORE.Models;
using FluentValidation.TestHelper;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE.Views.Fornecedor
{
    public partial class Cad_Fornecedor : Form
    {
        Models.Fornecedor forn = new Models.Fornecedor();

        public Cad_Fornecedor()
        {
            InitializeComponent();

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cad_Fornecedor_Load(object sender, EventArgs e)
        {
            dtg_cad_fornecedor.DataSource = forn.Carregadados();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            Models.Fornecedor mfornecedor = new Models.Fornecedor();
            ValidacaoFornecedor vf = new ValidacaoFornecedor();
            mfornecedor.Codigo = int.Parse(txt_codigo.Text.Replace("'", ""));
            mfornecedor.Razao_social = txt_razao_social.Text.Replace("'", "");
            mfornecedor.Nome_fantasia = txt_nome_fantasia.Text.Replace("'", "");
            mfornecedor.Datacadastro = DateTime.Now;
            var resultados = vf.Validate(mfornecedor);

            //Validacao
            if (mfornecedor != null)
            {


                if (resultados != null && resultados.ToString() != "")
                {
                    foreach (var erro in resultados.Errors)
                    {
                        MessageBox.Show(resultados.ToString());
                        MessageBox.Show(erro.ErrorMessage);
                        return;
                    }
                    //      MessageBox.Show(resultados.ToString());
                    //      MessageBox.Show("Ruim");

                }
                else
                {

                    mfornecedor.Inserir();
                    MessageBox.Show("Cadastrado com sucesso!");


                }

            }


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Código é: " + forn.Razao_social);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Carrega());
        }
        public string Carrega()
        {
            ArrayList ar1 = new ArrayList();
            string acumula = "";
            int i = 0;
            MySqlDataReader dr = null;
            string sql = "select * from tb_fornecedor";
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                ar1.Add(dr.GetValue(i));

                MessageBox.Show(ar1[i].ToString());
                i++;
            }
            con.Close();
            con.Dispose();
            return acumula = "";

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            Models.Fornecedor mfornecedor = new Models.Fornecedor();
            string sql = @"SELECT 
                    cd_fornecedor AS 'Codigo', 
                    nm_razao_social AS 'Razao Social',
                    nm_fantasia AS 'Nome Fantasia' 

                    FROM tb_fornecedor";
            dtg_cad_fornecedor.DataSource = mfornecedor.PesquisaFornecedor(sql, txt_pesquisa.Text, "cd_fornecedor", "nm_razao_social");
        }

        private void txt_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btn_pesquisa.PerformClick();
            }
        }

        private void txt_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

