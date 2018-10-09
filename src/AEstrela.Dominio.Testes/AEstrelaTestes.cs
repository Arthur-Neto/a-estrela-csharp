using NUnit.Framework;
using System.Collections.Generic;

namespace AEstrela.Dominio.Testes
{
    [TestFixture]
    public class AEstrelaTestes
    {
        private AEstrela aEstrela;
        private Nodo inicial;
        private Nodo destino;
        private List<Nodo> bloqueios;

        [SetUp]
        public void Inicializar()
        {
            int alturaGrid = 10;
            int larguraGrid = 10;
            double custoDiagonal = 1.4;
            double custoVH = 1;
            int inicioX = 0;
            int inicioY = 0;
            int finalX = 10;
            int finalY = 10;
            inicial = new Nodo(inicioX, inicioY);
            destino = new Nodo(finalX, finalY);
            bloqueios = new List<Nodo>() { new Nodo(4, 0),
                                           new Nodo(4, 1),
                                           new Nodo(4, 2),
                                           new Nodo(4, 3),
                                           new Nodo(4, 4),
                                           new Nodo(4, 5),
                                           new Nodo(4, 6),
                                           new Nodo(4, 7) };
            aEstrela = new AEstrela(alturaGrid, larguraGrid, inicial, destino, custoDiagonal, custoVH);
        }

        [Test]
        public void AEstrela_Dominio_ProcurarCaminho_DeveRetornarMatrizMenorCaminho()
        {

        }
    }
}
