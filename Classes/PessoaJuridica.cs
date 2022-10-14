using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ATIV_UC12_SA2_ER2.Interfaces;

namespace ATIV_UC12_SA2_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override double PagarImposto(double rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento * 0.94; // desconto de 6%
            }
            else if (rendimento >= 5001 && rendimento <= 10000)
            {
                //Salário acima de 10.001
                 return rendimento * 0.92; // desconto de 8%
            }
           return  rendimento * 0.90; // desconto de 10%;
        }

        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                {
                        return true;
                    }

                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }//Fim do método ValidarCnpj
    }
}