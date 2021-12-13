using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CursoProfissional.Entities;

namespace CursoProfissional.Controller
{
    class ControllerUtilizador
    {
        Connection connection = new Connection();

        MySqlCommand sqlCommand;

        public Utilizador EntrarCU(Utilizador utilizador)
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("SELECT * FROM utilizador WHERE login = @login AND password = @password", connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@login", utilizador.Login);
                sqlCommand.Parameters.AddWithValue("@password", utilizador.Password);
                MySqlDataReader dtReader;
                dtReader = sqlCommand.ExecuteReader();
                if (dtReader.HasRows)
                {
                    while (dtReader.Read())
                    {
                        utilizador.Login = Convert.ToString(dtReader["login"]);
                        utilizador.Password = Convert.ToString(dtReader["password"]);
                    }
                }
                else
                {
                    utilizador.Login = null;
                    utilizador.Password = null;
                }
                return utilizador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
