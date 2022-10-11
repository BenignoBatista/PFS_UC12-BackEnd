using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATIV_UC12_SA2_ER2.Interfaces;

namespace ATIV_UC12_SA2_ER2.Classes
{
    //Uma classe abstrata não pode ser instanciada, porém a classe que a herda pode
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public Endereco endereco { get; set; }
        public double ?rendimento { get; set; }

        
        //implementando o método pagarImposto da IPessoa
        double IPessoa.PagarImposto(double rendimento)
        {
            throw new NotImplementedException();
        }

        double IPessoa.Teste(double rendimento)
        {
            throw new NotImplementedException();
        }
    }
}