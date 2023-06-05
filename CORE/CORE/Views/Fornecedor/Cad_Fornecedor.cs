using CORE.Controllers;
using CORE.Models;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            
            Models.Fornecedor mfornecedor = new Models.Fornecedor();
            ValidacaoFornecedor vf = new ValidacaoFornecedor();
            mfornecedor.Codigo = int.Parse(txt_codigo.Text);
            mfornecedor.Razao_social = txt_razao_social.Text;
            mfornecedor.Nome_fantasia = txt_nome_fantasia.Text;
            mfornecedor.Datacadastro = DateTime.Now;
            var resultados = vf.Validate(mfornecedor);

            //Validacao
            if (mfornecedor!=null) 
               {

                  
                   if(resultados!=null && resultados.ToString() != "") 
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
            Conexao c = new Conexao();
            c.connect();
        }
    }
    }

