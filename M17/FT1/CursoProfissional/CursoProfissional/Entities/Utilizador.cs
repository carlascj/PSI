using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProfissional.Entities
{
    class Utilizador
    {
        private int idUtilizador;
        private String login;
        private String password;
        private String nomeUtilizador;
        private String emailUtilizador;

        public int IdUtilizador { get => idUtilizador; set => idUtilizador = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string NomeUtilizador { get => nomeUtilizador; set => nomeUtilizador = value; }
        public string EmailUtilizador { get => emailUtilizador; set => emailUtilizador = value; }
    }
}
