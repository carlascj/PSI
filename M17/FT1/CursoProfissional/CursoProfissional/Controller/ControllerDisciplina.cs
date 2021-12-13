using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //Biblioteca inserida após inserção nas References
using MySql.Data.MySqlClient; ////Biblioteca inserida após inserção nas References
using System.Data;
using System.Windows.Forms;
using CursoProfissional.Entities;

namespace CursoProfissional.Controller
{
    class ControllerDisciplina
    {
        //String myConnection = "SERVER=localhost; DATABASE=curso_profissional; UID=root; PWD=Covid-19;";
        //MySqlConnection sqlConnection = null;
        
        Connection connection = new Connection();
       
        MySqlCommand sqlCommand;

        internal DataTable ListarDisciplinasCD()
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("SELECT * FROM disciplina ORDER BY id_disc DESC", connection.sqlConnection);
                MySqlDataAdapter dtAdapter = new MySqlDataAdapter();
                dtAdapter.SelectCommand = sqlCommand;
                DataTable dtTable = new DataTable();
                dtAdapter.Fill(dtTable);
                connection.FecharConexao();
                return dtTable;
            }
            catch (Exception ex)
            {
                connection.FecharConexao();
                MessageBox.Show("Erro ao listar as disciplinas!\n\n" + ex.Message);
                throw ex;
            }
        }

        internal void GuardarDisciplinasCD(Disciplina disc)
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("INSERT INTO disciplina(nome_disc, sigla_disc, componente_disc) VALUES (@nome_disc, @sigla_disc, @componente_disc)", connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nome_disc", disc.Nome);
                sqlCommand.Parameters.AddWithValue("@sigla_disc", disc.Sigla);
                sqlCommand.Parameters.AddWithValue("@componente_disc", disc.Componente);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Disciplina guardada com sucesso!");
                connection.FecharConexao();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar a disciplina!\n\n" + ex);
                connection.FecharConexao();
            }
        }

        internal void AlterarDisciplinasCD(Disciplina disc)
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("UPDATE disciplina SET nome_disc = @nome_disc, sigla_disc = @sigla_disc, componente_disc = @componente_disc WHERE id_disc = @id_disc", connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_disc", disc.Id);
                sqlCommand.Parameters.AddWithValue("@nome_disc", disc.Nome);
                sqlCommand.Parameters.AddWithValue("@sigla_disc", disc.Sigla);
                sqlCommand.Parameters.AddWithValue("@componente_disc", disc.Componente);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Disciplina alterada com sucesso!");
                connection.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a disciplina!\n\n" + ex);
                connection.FecharConexao();
            }
        }

        internal void EliminarDisciplinasCD(Disciplina disc)
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("DELETE FROM disciplina WHERE id_disc = @id_disc", connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id_disc", disc.Id);
              
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Disciplina eliminada com sucesso!");
                connection.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar a disciplina!\n\n" + ex);
                connection.FecharConexao();
            }
        }

        internal DataTable PesquisarNomeCD(Disciplina disc)
        {
            try
            {
                connection.AbrirConexao();
                sqlCommand = new MySqlCommand("SELECT * FROM disciplina WHERE nome_disc LIKE @nome_disc", connection.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nome_disc", disc.Nome + "%");
                MySqlDataAdapter dtAdapter = new MySqlDataAdapter();
                dtAdapter.SelectCommand = sqlCommand;
                DataTable dtTable = new DataTable();
                dtAdapter.Fill(dtTable);
                connection.FecharConexao();
                return dtTable;

            }
            catch (Exception ex)
            {
                connection.FecharConexao();
                MessageBox.Show("Erro ao pesquisar a disciplina!\n\n" + ex.Message);
                throw ex;
            }
        }
    }
}