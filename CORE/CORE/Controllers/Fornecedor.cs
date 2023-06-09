using CORE.Views.Fornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace CORE.Controllers
{
    internal class Fornecedor
    {
   
      


        /* 
           private MySqlConnection conn;
                static void connect()
                {
                    string server = "localhost";
                    string database = "mysqldb1";
                    string user = "root";
                    string password = "u1s2e3r4";
                    string port = "3306";
                    string sslM = "none";

                    string connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

                    conn = new MySqlConnection(connString);
                    try
                    {
                        conn.Open();

                    Messagebox.Show("Connection Successful");

                        conn.Close();
                    }
                    catch (MySqlException e)
                    {
                        Messagebox.Show(e.Message + connString);
                    }

                }

         */
      /*  public void InserirDados(String itemcodigo, String itemdescricao, Double itempreco)
        {
            MySqlConnection con = new MySqlConnection();
            con = new MySqlConnection();
      
            con.ConnectionString = 
            String query = "INSERT INTO inventario (itemcodigo, itemdescricao, itempreco) VALUES";
            query += "(?itemcodigo, ?itemdescricao, ?itempreco)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?itemcodigo", itemcodigo);
                cmd.Parameters.AddWithValue("?itemdescricao", itemdescricao);
                cmd.Parameters.AddWithValue("?itempreco", itempreco);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
      */
        public void CadastrarFornecedor(int cd_fornecedor, String nm_razao_social, String nm_fantasia, DateTime dt_cadastro)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");



            String query = "INSERT INTO tb_fornecedor (cd_fornecedor, nm_razao_social, nm_fantasia,dt_cadastro ) VALUES";
            query += "(?cd_fornecedor, ?nm_razao_social, ?nm_fantasia,?dt_cadastro)";
            try
            {
                con.Open();
             
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.AddWithValue("?cd_fornecedor", cd_fornecedor);
                cmd.Parameters.AddWithValue("?nm_razao_social", nm_razao_social);
                cmd.Parameters.AddWithValue("?nm_fantasia", nm_fantasia);
                cmd.Parameters.AddWithValue("?dt_cadastro", dt_cadastro);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
              
            }
            finally
            {
                
            }



        }

        public void DeletarFornecedor()
        {

        }

        public void EditarFornecedor()
        {

        }

        public void GetFornecedor()
        {

        }
        public DataTable Carregadados()
        {
            string sql = @"SELECT 
cd_fornecedor AS 'Codigo', 
nm_razao_social AS 'Razao Social',
nm_fantasia AS 'Nome Fantasia' 

FROM tb_fornecedor;";
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());
            con.Close();
            con.Dispose();
            return data;

        }

        public DataTable PesquisarFornecedor(String sql,String pesquisa, String argumento1,String argumento2)
        {//SELECT nome FROM tblalunos WHERE nome LIKE "Jos%"

            /*
                     @"SELECT 
                    cd_fornecedor AS 'Codigo', 
                    nm_razao_social AS 'Razao Social',
                    nm_fantasia AS 'Nome Fantasia' 

                    FROM tb_fornecedor where cd_fornecedor like '"+pesquisa+"%' or " + "nm_razao_social like '"+pesquisa+"%';" 
             */
            sql = @sql + " where "+@argumento1+" like '"+@pesquisa+"%' or " + @argumento2 + " like '"+@pesquisa+"%'";
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());
            con.Close();
            con.Dispose();
            return data;
        }

   


    }
}
