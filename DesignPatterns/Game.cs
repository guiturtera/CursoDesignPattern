using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IMapa 
    {
        void IniciarMapa();
        void FinalizarMapa();
        int NumeroJogadores { get; }
    }

    public class MapaGelo : IMapa
    {
        public int NumeroJogadores { get; private set; }
        public MapaGelo(int numeroJogadores)
        {
            NumeroJogadores = numeroJogadores;
        }

        public void IniciarMapa()
        {
            Console.WriteLine("Iniciando mapa gelo...");
        }

        public void FinalizarMapa() 
        {
            Console.WriteLine("Apagando mapa gelo...");
        }
    }

    public class MapaFogo : IMapa
    {
        public int NumeroJogadores { get; private set; }
        public MapaFogo(int numeroJogadores)
        {
            NumeroJogadores = numeroJogadores;
        }

        public void IniciarMapa()
        {
            Console.WriteLine("Iniciando mapa fogo...");
        }

        public void FinalizarMapa()
        {
            Console.WriteLine("Apagando mapa fogo...");
        }
    }

    public class MapaAr : IMapa
    {
        public int NumeroJogadores { get; private set; }
        public MapaAr(int numeroJogadores)
        {
            NumeroJogadores = numeroJogadores;
        }
        public void IniciarMapa()
        {
            Console.WriteLine("Iniciando mapa ar...");
        }

        public void FinalizarMapa()
        {
            Console.WriteLine("Apagando mapa ar...");
        }
    }
}
