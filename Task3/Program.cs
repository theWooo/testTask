namespace Task3 {
    internal class Program {
        static void Main(string[] args) {
            Main m = new();
            m.main();
        }
    }
    class Main {
        public void main() {
            int vasyaAge = 60;
            int katyaAge = 35;
            int mishaAge = 15;
            int min = vasyaAge;
            int middle = katyaAge;
            int max = mishaAge;
            if (min > middle) {
                swap(ref min, ref middle);
            }
            if (middle > max) {
                swap(ref middle, ref max);
            }
            if (min > middle) {
                swap(ref min, ref middle);
            }
            Console.WriteLine($"Minimal age: {min}");
            Console.WriteLine($"Middle age: {middle}");
            Console.WriteLine($"Maximum age: {max}");
        }
        private void swap(ref int a, ref int b) {
            int swap = a;
            a = b;
            b = swap;
        }
    }
}
