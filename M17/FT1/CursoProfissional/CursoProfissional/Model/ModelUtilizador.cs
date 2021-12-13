using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoProfissional.Entities;
using CursoProfissional.Controller;

namespace CursoProfissional.Model
{
    class ModelUtilizador
    {
        ControllerUtilizador controllerUtilizador = new ControllerUtilizador();

        public Utilizador EntrarMU(Utilizador utilizador)
        {
            try
            {
                return controllerUtilizador.EntrarCU(utilizador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
