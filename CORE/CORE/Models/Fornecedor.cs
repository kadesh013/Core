using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Models
{
    internal class Fornecedor
    {
     
  
        private int codigo;
        private string razao_social;
        private string nome_fantasia;
        private string endereco;
        private string numero;
        private string cep;
        private string cidade;
        private string bairro;
        private string estado;
        private float cnpj;
        private string ie;
        private string isento;
        private string contato;
        private string telefone;
        private DateTime datacadastro;
     
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value;}
        }
        public string Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }
        public string Nome_fantasia
        {
            get { return nome_fantasia; }
            set { nome_fantasia = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public float Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Ie
        {
            get { return ie; }
            set { ie = value; }
        }

        public string Isento
        {
            get { return isento; }
            set { isento = value; }
        }
        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public DateTime Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

      
            public void Inserir()
        {
            Controllers.Fornecedor cforn = new Controllers.Fornecedor();
            cforn.CadastrarFornecedor(Codigo, Razao_social, Nome_fantasia,Datacadastro);
           
        }

        public DataTable Carregadados()
        {
            Controllers.Fornecedor cforn = new Controllers.Fornecedor();

            return cforn.Carregadados(); 
        }

        public DataTable PesquisaFornecedor(String sql,String pesquisa,String argumento1,String argumento2)
        {
            Controllers.Fornecedor cforn = new Controllers.Fornecedor();

            return cforn.PesquisarFornecedor(sql,pesquisa.Replace("'", ""), argumento1,argumento2);
        }




    }
}
