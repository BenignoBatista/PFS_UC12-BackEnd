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
        // public PessoaFisica(string dataNasc){
        //     this.setDataNascimento(dataNasc);
        // }
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }

        public override double PagarImposto(double rendimento)
        {
           if (rendimento <= 1500)
           {
            return rendimento; // isento
           } 
           else if(rendimento >= 1501 && rendimento <= 5000)
           {
                return rendimento - (rendimento / 100) * 3; // 3%
                // return rendimento * 1.03% // 3%
           }
           
        // quem ganha acima de 5001
            // return rendimento - (rendimento / 100) * 5; //5%
            return rendimento * 0.95; //5%
        }

        //set
        // public void setDataNascimento(string dataNasc) {
        //     this.dataNascimento = dataNasc;
        // }
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