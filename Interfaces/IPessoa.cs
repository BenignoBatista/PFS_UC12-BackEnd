using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//As classes que herdarem a interface terão que implementar todos os seus métodos
namespace ATIV_UC12_SA2_ER2.Interfaces
{
    public interface IPessoa
    {
        public abstract double PagarImposto(double rendimento);
        public abstract double Teste(double rendimento);
    }
}