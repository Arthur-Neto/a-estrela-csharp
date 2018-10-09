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

        public Nodo(int x, int y, double peso)
        {
            X = x;
            Y = y;
            Peso = peso;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public double Peso { get; set; }

        public override bool Equals(object obj)
        {
            var nodo = obj as Nodo;
            return nodo != null &&
                   X == nodo.X &&
                   Y == nodo.Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1215089267;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Peso.GetHashCode();
            return hashCode;
        }
    }
}
