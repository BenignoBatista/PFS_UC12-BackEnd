using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATIV_UC12_SA2_ER2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNasc);
    }
}