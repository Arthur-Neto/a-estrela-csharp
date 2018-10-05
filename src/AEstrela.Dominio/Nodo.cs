namespace AEstrela.Dominio
{
    public class Nodo
    {
        public Nodo(int x, int y)
        {
            X = x;
            Y = y;
            Peso = 0;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public double Peso { get; set; }
    }
}
