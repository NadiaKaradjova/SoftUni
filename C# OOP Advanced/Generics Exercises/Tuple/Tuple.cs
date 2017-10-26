namespace Tuples
{
    public class Tuple<T, U>
    {
        private T item1;

        private U item2;

        public Tuple(T item1, U item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T Item1 { get; private set; }
        public U Item2 { get; private set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
