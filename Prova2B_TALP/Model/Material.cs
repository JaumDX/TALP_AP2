using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2B_TALP.Model
{

    class Material
    {

        string nome { get; set; }
        int qtde { get; set; }
        double valorUnidade { get; set; }


        public Material(string nome, int qtde, double valorUnidade)
        {

            this.nome = nome;
            this.qtde = qtde;
            this.valorUnidade = valorUnidade;
        }


    }
}
