using System;
using System.Collections.Generic;

namespace AEstrela.Dominio
{
    public class AEstrela
    {
        public AEstrela(int alturaGrid, int larguraGrid, IList<Nodo> bloqueados, Nodo inicial, Nodo destino, double custoDiagonal, double custoVerticalHorizontal)
        {
            AlturaGrid = alturaGrid;
            LarguraGrid = larguraGrid;
            Bloqueados = bloqueados;
            Inicial = inicial;
            Destino = destino;
            Atual = inicial;
            CustoDiagonal = custoDiagonal;
            CustoVerticalHorizontal = custoVerticalHorizontal;
            Gerados = new List<Nodo>();
            Gerados.Add(Atual);
            Expandidos = new List<Nodo>();
            Grid = new Nodo[LarguraGrid, AlturaGrid];
        }

        public AEstrela(int alturaGrid, int larguraGrid, Nodo inicial, Nodo destino, double custoDiagonal, double custoVerticalHorizontal)
        {
            AlturaGrid = alturaGrid;
            LarguraGrid = larguraGrid;
            Inicial = inicial;
            Destino = destino;
            Atual = inicial;
            CustoDiagonal = custoDiagonal;
            CustoVerticalHorizontal = custoVerticalHorizontal;
            Gerados = new List<Nodo>();
            Gerados.Add(Atual);
            Expandidos = new List<Nodo>();
            Bloqueados = new List<Nodo>();
            Grid = new Nodo[LarguraGrid, AlturaGrid];
        }

        public double CustoDiagonal { get; set; }
        public double CustoVerticalHorizontal { get; set; }
        public int AlturaGrid { get; set; }
        public int LarguraGrid { get; set; }
        public Nodo[,] Grid { get; set; }
        public IList<Nodo> Gerados { get; set; }
        public IList<Nodo> Expandidos { get; set; }
        public IList<Nodo> Bloqueados { get; set; }
        public Nodo Inicial { get; set; }
        public Nodo Destino { get; set; }
        public Nodo Atual { get; set; }

        public List<Nodo> ProcurarCaminho()
        {
            List<Nodo> caminho = new List<Nodo>();
            caminho.Add(Atual);

            while(Gerados.Count > 0)
            {

            }

            return caminho;
        }

        private void GerarNosFilhos()
        {

            Nodo gerado = new Nodo(0, 0);
            if (!Expandidos.Contains(gerado))
                Gerados.Add(gerado);
        }

        private bool VerificarEstadoFinal()
        {
            if(Atual.Equals(Destino))
                return true;
            else
                return false;
        }

        private double VerificarCusto()
        {
            return Math.Abs(Destino.X - Atual.X) + Math.Abs(Destino.Y - Atual.Y);
        }

        private void MoverParaMenorCusto()
        {

        }

        private List<Nodo> PegarAdjacentes()
        {
            List<Nodo> adjacentes = new List<Nodo>();

            if (Atual.X - 1 >= 0)
                adjacentes.Add(Grid[Atual.X - 1, Atual.Y]);
            if (Atual.X < Grid.GetUpperBound(0))
                adjacentes.Add(Grid[Atual.X + 1, Atual.Y]);
            if (Atual.Y - 1 >= 0)
                adjacentes.Add(Grid[Atual.X, Atual.Y - 1]);
            if (Atual.Y < Grid.GetUpperBound(1))
                adjacentes.Add(Grid[Atual.X, Atual.Y + 1]);

            return adjacentes;
        }

    }
}
