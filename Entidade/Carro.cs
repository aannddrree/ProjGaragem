using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Carro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public int AnoFabrica { get; set; }

        public int AnoModelo { get; set; }
        public Motor Motor { get; set; }
    }
}
