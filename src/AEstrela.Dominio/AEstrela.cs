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
            Expandidos = new List<Nodo>();
            Grid = new int[LarguraGrid, AlturaGrid];
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
            Expandidos = new List<Nodo>();
            Bloqueados = new List<Nodo>();
            Grid = new int[LarguraGrid, AlturaGrid];
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

        public int[,] ProcurarCaminho()
        {
            return Grid;
        }


        private void GerarNosFilhos()
        {

        }

        private bool VerificarEstadoFinal()
        {
            if(Gerados.Contains(Destino))
                return true;
            else
                return false;
        }

        private void VerificarCusto()
        {

        }

        private void MoverParaMenorCusto()
        {

        }

    }
}
