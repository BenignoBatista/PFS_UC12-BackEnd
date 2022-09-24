using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIV_UC12_SA2_ER2.Interfaces;

namespace ATIV_UC12_SA2_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}