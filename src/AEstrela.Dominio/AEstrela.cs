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
            Grid = new int[LarguraGrid, AlturaGrid];
            Bloqueados = bloqueados;
            Inicial = inicial;
            Destino = destino;
            Atual = inicial;
            CustoDiagonal = custoDiagonal;
            CustoVerticalHorizontal = custoVerticalHorizontal;
            Gerados = new List<Nodo>
            {
                Atual
            };
            Expandidos = new List<Nodo>();
        }

        public AEstrela(int alturaGrid, int larguraGrid, Nodo inicial, Nodo destino, double custoDiagonal, double custoVerticalHorizontal)
        {
            AlturaGrid = alturaGrid;
            LarguraGrid = larguraGrid;
            Grid = new int[LarguraGrid, AlturaGrid];
            Inicial = inicial;
            Destino = destino;
            Atual = inicial;
            CustoDiagonal = custoDiagonal;
            CustoVerticalHorizontal = custoVerticalHorizontal;
            Gerados = new List<Nodo>
            {
                Atual
            };
            Expandidos = new List<Nodo>();
            Bloqueados = new List<Nodo>();
        }

        public double CustoDiagonal { get; set; }
        public double CustoVerticalHorizontal { get; set; }
        public int AlturaGrid { get; set; }
        public int LarguraGrid { get; set; }
        public int[,] Grid { get; set; }
        public IList<Nodo> Gerados { get; set; }
        public IList<Nodo> Expandidos { get; set; }
        public IList<Nodo> Bloqueados { get; set; }
        public Nodo Inicial { get; set; }
        public Nodo Destino { get; set; }
        public Nodo Atual { get; set; }

        public List<Nodo> ProcurarCaminho()
        {
            List<Nodo> caminho = new List<Nodo>();

            while (Gerados.Count > 0)
            {
                caminho.Add(Atual);

                GerarNosFilhos();
                if (VerificarEstadoFinal()) return caminho;
                MoverParaMenorCusto();
            }

            foreach (var item in caminho)
            {
                Console.Write("\n" + item.X + " " + item.Y);
            }

            return caminho;
        }

        private void GerarNosFilhos() //falta os diagonais
        {
            Nodo gerado;
            if (Atual.X - 1 >= 0)
            {
                gerado = new Nodo(Atual.X - 1, Atual.Y);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado))
                    Gerados.Add(gerado);
            }
            if (Atual.X < Grid.GetUpperBound(0))
            {
                gerado = new Nodo(Atual.X + 1, Atual.Y);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado))
                    Gerados.Add(gerado);
            }
            if (Atual.Y - 1 >= 0)
            {
                gerado = new Nodo(Atual.X, Atual.Y - 1);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado))
                    Gerados.Add(gerado);
            }
            if (Atual.Y < Grid.GetUpperBound(1))
            {
                gerado = new Nodo(Atual.X, Atual.Y + 1);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado))
                    Gerados.Add(gerado);
            }
        }

        private bool VerificarEstadoFinal()
        {
            if (Gerados.Contains(Destino))
                return true;
            else
                return false;
        }

        private double VerificarCusto(Nodo nodo)
        {
            return Math.Abs(Destino.X - nodo.X) + Math.Abs(Destino.Y - nodo.Y);
        }

        private void MoverParaMenorCusto()
        {
            Gerados.Remove(Atual);
            Expandidos.Add(Atual);

            Nodo nodoMenorCusto = Atual;
            double menorCusto = 99999;

            foreach (Nodo nodo in Gerados)
            {
                double custo = VerificarCusto(nodo);
                if (menorCusto > custo)
                {
                    menorCusto = custo;
                    nodoMenorCusto = nodo;
                }
            }

            Atual = nodoMenorCusto;
        }
    }
}
