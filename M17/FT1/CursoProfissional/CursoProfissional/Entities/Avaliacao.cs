using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProfissional.Entities
{
    public class Avaliacao
    {

        //Propriedades
        public string Sigla { get; set; }
        public byte Modulo { get; set; }
        public byte Nota { get; set; }
        public DateTime DataAv { get; set; }

    }
}
