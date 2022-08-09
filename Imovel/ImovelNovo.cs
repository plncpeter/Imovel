using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel
{
    internal class ImovelNovo : Imovel
    {
        private double _preco;
        public double Preco
        {
            get => _preco;
            set => _preco = value * 1.2;
        }
    }
}
