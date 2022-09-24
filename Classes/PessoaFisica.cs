using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIV_UC12_SA2_ER2.Interfaces;

namespace ATIV_UC12_SA2_ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set;}
        public DateTime dataNascimento { get; set; }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}