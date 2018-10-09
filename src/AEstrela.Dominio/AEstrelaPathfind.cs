using System;
using System.Collections.Generic;
using System.Linq;

namespace AEstrela.Dominio
{
    public class AEstrelaPathfind
    {
        public AEstrelaPathfind(int alturaGrid, int larguraGrid, IList<Nodo> bloqueados, Nodo inicial, Nodo destino, decimal custoDiagonal, decimal custoVerticalHorizontal)
        {
            AlturaGrid = alturaGrid;
            LarguraGrid = larguraGrid;
            Grid = new decimal[LarguraGrid, AlturaGrid];
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

        public AEstrelaPathfind(int alturaGrid, int larguraGrid, Nodo inicial, Nodo destino, decimal custoDiagonal, decimal custoVerticalHorizontal)
        {
            AlturaGrid = alturaGrid;
            LarguraGrid = larguraGrid;
            Grid = new decimal[LarguraGrid, AlturaGrid];
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

        public decimal CustoDiagonal { get; set; }
        public decimal CustoVerticalHorizontal { get; set; }
        public int AlturaGrid { get; set; }
        public int LarguraGrid { get; set; }
        public decimal[,] Grid { get; set; }
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

            return caminho;
        }

        private void GerarNosFilhos()
        {
            Nodo gerado;
            //Adjacente Norte
            if (Atual.Y - 1 >= 0)
            {
                gerado = new Nodo(Atual.X, Atual.Y - 1);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                {
                    gerado.Peso = VerificarCusto(gerado, false);
                    Gerados.Add(gerado);
                    if (VerificarEstadoFinal()) return;
                }
            }
            //Adjacente Nordeste
            if (Atual.X < Grid.GetUpperBound(0))
            {
                if (Atual.Y - 1 >= 0)
                {
                    gerado = new Nodo(Atual.X + 1, Atual.Y - 1);
                    if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                    {
                        gerado.Peso = VerificarCusto(gerado, true);
                        Gerados.Add(gerado);
                        if (VerificarEstadoFinal()) return;
                    }
                }
            }
            //Adjacente Leste
            if (Atual.X < Grid.GetUpperBound(0))
            {
                gerado = new Nodo(Atual.X + 1, Atual.Y);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                {
                    gerado.Peso = VerificarCusto(gerado, false);
                    Gerados.Add(gerado);
                    if (VerificarEstadoFinal()) return;
                }
            }
            //Adjacente Sudeste
            if (Atual.X < Grid.GetUpperBound(0))
            {
                if (Atual.Y < Grid.GetUpperBound(1))
                {
                    gerado = new Nodo(Atual.X + 1, Atual.Y + 1);
                    if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                    {
                        gerado.Peso = VerificarCusto(gerado, true);
                        Gerados.Add(gerado);
                        if (VerificarEstadoFinal()) return;
                    }
                }
            }
            //Adjacente Sul
            if (Atual.Y < Grid.GetUpperBound(1))
            {
                gerado = new Nodo(Atual.X, Atual.Y + 1);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                {
                    gerado.Peso = VerificarCusto(gerado, false);
                    Gerados.Add(gerado);
                    if (VerificarEstadoFinal()) return;
                }
            }
            //Adjacente Sudoeste
            if (Atual.X - 1 >= 0)
            {
                if (Atual.Y < Grid.GetUpperBound(1))
                {
                    gerado = new Nodo(Atual.X - 1, Atual.Y + 1);
                    if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                    {
                        gerado.Peso = VerificarCusto(gerado, true);
                        Gerados.Add(gerado);
                        if (VerificarEstadoFinal()) return;
                    }
                }
            }
            //Adjancente Oeste
            if (Atual.X - 1 >= 0)
            {
                gerado = new Nodo(Atual.X - 1, Atual.Y);
                if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                {
                    gerado.Peso = VerificarCusto(gerado, false);
                    Gerados.Add(gerado);
                    if (VerificarEstadoFinal()) return;
                }
            }
            //Adjacente Noroeste
            if (Atual.X - 1 >= 0)
            {
                if (Atual.Y - 1 >= 0)
                {
                    gerado = new Nodo(Atual.X - 1, Atual.Y - 1);
                    if (!Expandidos.Contains(gerado) && !Bloqueados.Contains(gerado) && !Gerados.Contains(gerado))
                    {
                        gerado.Peso = VerificarCusto(gerado, true);
                        Gerados.Add(gerado);
                        if (VerificarEstadoFinal()) return;
                    }
                }
            }
        }

        private bool VerificarEstadoFinal()
        {
            if (Gerados.Contains(Destino))
                return true;
            else
                return false;
        }

        private decimal VerificarCusto(Nodo nodo, bool IsDiagonal)
        {
            if (IsDiagonal)
                return Math.Abs(Destino.X - nodo.X) + Math.Abs(Destino.Y - nodo.Y) + CustoDiagonal;
            else
                return Math.Abs(Destino.X - nodo.X) + Math.Abs(Destino.Y - nodo.Y) + CustoVerticalHorizontal;
        }

        private void MoverParaMenorCusto()
        {
            Gerados.Remove(Atual);
            Expandidos.Add(Atual);

            Nodo nodoMenorCusto = Gerados.First();

            foreach (Nodo nodo in Gerados)
            {
                if (nodoMenorCusto.Peso > nodo.Peso)
                {
                    nodoMenorCusto = nodo;
                }
            }

            Atual = nodoMenorCusto;
            Grid[Atual.X, Atual.Y] = Atual.Peso;
        }
    }
}
