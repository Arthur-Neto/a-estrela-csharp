using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace AEstrela.Dominio.Testes
{
    [TestFixture]
    public class AEstrelaTestes
    {
        private AEstrelaPathfind aEstrela;
        private Nodo inicial;
        private Nodo destino;
        private List<Nodo> bloqueios;

        [Test]
        public void AEstrela_Dominio_ProcurarCaminho_DeveRetornaMenorCaminho_ComGridDezPorDez()
        {
            int alturaGrid = 10;
            int larguraGrid = 10;
            decimal custoDiagonal = 1.4m;
            decimal custoVH = 1;
            int inicioX = 0;
            int inicioY = 0;
            int finalX = 9;
            int finalY = 9;
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
            aEstrela = new AEstrelaPathfind(alturaGrid, larguraGrid, inicial, destino, custoDiagonal, custoVH);
            int numeroDeNodosEsperados = 13;
            aEstrela.Bloqueados = bloqueios;

            List<Nodo> resultado = aEstrela.ProcurarCaminho();

            resultado.Count.Should().Be(numeroDeNodosEsperados);
        }

        [Test]
        public void AEstrela_Dominio_ProcurarCaminho_DeveRetornaMenorCaminho_InicioFinalMatriz()
        {
            int alturaGrid = 10;
            int larguraGrid = 10;
            decimal custoDiagonal = 1.4m;
            decimal custoVH = 1;
            int inicioX = 0;
            int inicioY = 9;
            int finalX = 9;
            int finalY = 9;
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
            aEstrela = new AEstrelaPathfind(alturaGrid, larguraGrid, bloqueios, inicial, destino, custoDiagonal, custoVH);
            int numeroDeNodosEsperados = 9;
            aEstrela.Bloqueados = bloqueios;

            List<Nodo> resultado = aEstrela.ProcurarCaminho();

            resultado.Count.Should().Be(numeroDeNodosEsperados);
        }

        [Test]
        public void AEstrela_Dominio_ProcurarCaminho_DeveRetornaMenorCaminho_InicioPenultimaLinha()
        {
            int alturaGrid = 20;
            int larguraGrid = 20;
            decimal custoDiagonal = 1.4m;
            decimal custoVH = 1;
            int inicioX = 0;
            int inicioY = 18;
            int finalX = 19;
            int finalY = 19;
            inicial = new Nodo(inicioX, inicioY);
            destino = new Nodo(finalX, finalY);
            bloqueios = new List<Nodo>();
            aEstrela = new AEstrelaPathfind(alturaGrid, larguraGrid, bloqueios, inicial, destino, custoDiagonal, custoVH);
            int numeroDeNodosEsperados = 19;
            aEstrela.Bloqueados = bloqueios;

            List<Nodo> resultado = aEstrela.ProcurarCaminho();

            resultado.Count.Should().Be(numeroDeNodosEsperados);
        }
    }
}
