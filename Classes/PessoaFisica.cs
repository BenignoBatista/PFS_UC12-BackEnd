using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIV_UC12_SA2_ER2.Interfaces;

namespace ATIV_UC12_SA2_ER2.Classes
{
    //A Interface de vir depois da classe conforme feito abaixo.
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public PessoaFisica(string dataNasc){
            this.setDataNascimento(dataNasc);
        }
        public string ?cpf { get; private set; }
        public string ?dataNascimento { get; set; }

        //set
        public void setDataNascimento(string dataNasc) {
            this.dataNascimento = dataNasc;
        }
        public bool ValidarDataNascimento(string dataNasc) // Recebeu 20/07/1982
        {
            DateTime dataConvertida;

            if (DateTime.TryParse(dataNasc, out dataConvertida)) {
                // System.Console.WriteLine(dataConvertida);

                DateTime dataAtual = DateTime.Today;

                double idade = (dataAtual - dataConvertida).TotalDays / 365;

                if(idade >= 18) {
                    return true;
                } else {
                    return false;
                }

                // System.Console.WriteLine(idade);
                
            } else {
                return false;
            }
            
        }
    }
}