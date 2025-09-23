using System.Linq;
namespace Task2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(Evaluator.getCircleArea(15));
            Console.WriteLine(Evaluator.getCircleArea(5));
            Console.WriteLine(Evaluator.getTriangleArea(5,5,5));
            Console.WriteLine(Evaluator.getTriangleArea(6,7,12));
            Console.WriteLine(Evaluator.getSphereVolume(5));
            Console.WriteLine(Evaluator.getSphereVolume(1));
            Console.WriteLine(Evaluator.isAPossibleTriangle(2, 3, 4));
            Console.WriteLine(Evaluator.isAPossibleTriangle(2, 3, 6));
        }
    }
    class Evaluator {
        public static double getCircleArea(double radius) => Math.PI * Math.Pow(radius, 2);
        public static double getTriangleArea(double a,double b, double c) {
            if (!isAPossibleTriangle(a, b, c)) { throw new Exception("Невозможно построить треугольник с указанными сторонами"); }
            double P = (a + b + c) / 2;
            return Math.Sqrt(P*(P-a)*(P-b)*(P-c));
        }
        public static double getSphereVolume(double radius) => ((4 * Math.PI) / 3)  * Math.Pow(radius, 3);
        public static bool isAPossibleTriangle(double a, double b, double c) {
            double longest = new double[] { a, b, c }.OrderByDescending(it => it).First();
            return longest - (a + b + c - longest) < 0;
        }
    }
}