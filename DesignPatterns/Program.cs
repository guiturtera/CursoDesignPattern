using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            /*
            ILogger logger1 = Logger.GetInstance();
            logger1.Nome = "Guilherme";

            ILogger logger2 = Logger.GetInstance();
            logger2.Nome = "André";

            Console.WriteLine(logger1.Nome);

            if (logger1 != logger2)
                Console.WriteLine("DIFERENTES");
            else
                Console.WriteLine("IGUAIS");

            Console.ReadLine();*/
            #endregion

            #region Simple Factory
            Console.WriteLine("Escreva o mapa:");
            string mapaEscolhido = Console.ReadLine();


            IMapa mapa = MapaSimpleFactory.GetMapa(mapaEscolhido);

            mapa.IniciarMapa();
            Console.WriteLine($"Jogadores no mapa -> {mapa.NumeroJogadores}");
            mapa.FinalizarMapa();
            Console.ReadLine();
            #endregion
        }
    }
}
