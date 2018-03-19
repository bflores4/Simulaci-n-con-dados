using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prásctica_4_lanzamiento_de_dados
{
    class dado
    {
        private int _caraMostrada;

        public int caraMostrada
        {
            get { return _caraMostrada; }
        }
        
        public dado()
        {
            _caraMostrada = caraMostrada;
        }

        //Random r = new Random();
        static Random r = new Random(DateTime.Now.Millisecond);

        public int lanzarDado()
        {
            return _caraMostrada = r.Next(1, 7);
        }
    }
}
