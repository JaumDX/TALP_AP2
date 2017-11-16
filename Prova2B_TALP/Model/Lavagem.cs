using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2B_TALP.Model
{

    /// <summary>
    /// Classe com valores estáticos para definir o tipo de veículo na lavagem.
    /// </summary>
    public static class Veiculos
    {
        public static string caminhao { get { return "Caminhao"; } }
        public static string carro { get { return "Carro"; } }
        public static string moto { get { return "Moto"; } }
    }

    class Lavagem
    {
        
        int id;
        string nome { get; set; }
        string email { get; set; }
        string tipoVeiculo { get; set; }
        double custo { get; set; }
        



    }
}
