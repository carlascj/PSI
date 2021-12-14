using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoProfissional.Entities;
using CursoProfissional.Controller;

namespace CursoProfissional.Model
{
    class ModelDisciplina
    {
        ControllerDisciplina controllerDisciplina = new ControllerDisciplina();

        internal DataTable ListarDisciplinasMD()
        {
            try
            {
                DataTable dtTable = new DataTable();
                dtTable = controllerDisciplina.ListarDisciplinasCD();
                return dtTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void GuardarDisciplinasMD(Disciplina disc)
        {
            try
            {
                controllerDisciplina.GuardarDisciplinasCD(disc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void AlterarDisciplinasMD(Disciplina disc)
        {
            try
            {
                controllerDisciplina.AlterarDisciplinasCD(disc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void EliminarDisciplinasMD(Disciplina disc)
        {
            try
            {
                controllerDisciplina.EliminarDisciplinasCD(disc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable PesquisarNomeMD(Disciplina disc)
        {
            try
            {
                DataTable dtTable = new DataTable();
                dtTable = controllerDisciplina.PesquisarNomeCD(disc);
                return dtTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}