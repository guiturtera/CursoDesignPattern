using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MapaSimpleFactory
    {
        public static IMapa GetMapa(string nomeMapa) 
        {
            int numJogadores = 5;
            if (nomeMapa.Contains(":")) 
            {
                string[] raw = nomeMapa.Split(':');
                nomeMapa = raw[0];
                numJogadores = int.Parse(raw[1]);
            }
                

            IMapa mapa;
            if (nomeMapa == "MapaGelo")
                mapa = new MapaGelo(numJogadores);
            else if (nomeMapa == "MapaFogo")
                mapa = new MapaFogo(numJogadores);
            else
                mapa = new MapaAr(numJogadores);

            return mapa;
        }
    }
}
