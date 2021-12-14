using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProfissional
{
    class Connection
    {

        //HOSPEDAGEM NO SERVIDOR LOCAL
        String myConnection = "Persist Security Info=False; " +
            "SERVER=localhost; PORT=3307; DATABASE=curso_profissional;" +
            " UID=root; PWD=root;";

        //HOSPEDAGEM NO SERVIDOR EXTERNO
        //string conexao = "SERVER=mysql642.umbler.com; DATABASE=sistema_clientes; UID=hugosistema; PWD=sistemahugo; Port=41890";

        internal MySqlConnection sqlConnection = null;

        public void AbrirConexao()
        {
            try
            {
                sqlConnection = new MySqlConnection(myConnection);
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void FecharConexao()
        {
            try
            {
                sqlConnection = new MySqlConnection(myConnection);
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
