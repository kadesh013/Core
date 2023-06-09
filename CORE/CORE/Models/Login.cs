using CORE.Views.Fornecedor;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Models
{
    internal class Login
    {

        public bool Logando(string username, string password)
        {// 
            string sql = @"select nm_usuario, cd_senha from tb_usuarios where nm_usuario = @usuario and cd_senha = @senha;";
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=db_core; password=");


            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@usuario", username);
            cmd.Parameters.AddWithValue("@senha", password);
            con.Open();
            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {

                return true;
            }
            else
            {

                return false;
            }
            con.Close();

        }

        /*
          public void Login()
    {
        Conexao conexao = new Conexao();
        Conexao.Conectar();
        try
        {
            MySqlCommand comando = new MySqlCommand();
            //Comando SQL
            comando.CommandText = "select * from `pessoas` where `Usuario` = '@Usuario' and `Senha` = '@Senha'";
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Senha", Senha);
            //Conectar com o banco
            comando.Connection = Conexao.Conectar();
            //Executar Comando
            var resultado = comando.ExecuteScalar();

            if (resultado != null)
            { 
               Principal principal = new Principal();
               principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (MySqlException er)
        {
            MessageBox.Show("Erro do Banco de dados " + er, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Conexao.Desconectar();
            Conexao.Limpar();
        }
    }
         */
    }
}
