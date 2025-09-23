using System.Text;
using System;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator(-3, 26);
            while (true) {
                Console.WriteLine("Введите номер этажа: ");
                int floor = Convert.ToInt32(Console.ReadLine());
                elevator.move(floor);
            }
            //}
            //Elevator elevator = new Elevator(-3, 26);
            //foreach(int  a in Enumerable.Range(-5,35)){
            //    int floor = a;//Convert.ToInt32(Console.ReadLine());
            //    elevator.move(floor);
            //    Console.WriteLine("-----------------------------------------------------");
            //}
        }
    }
    class Elevator {
        private int minFloor;
        private int maxFloor;
        private int currentFloor;
        public Elevator(int minFloor, int maxFloor) {
            this.minFloor = minFloor;
            this.maxFloor = maxFloor;
            currentFloor = 1;
        }
        public int getCurrentFloor() {
            return currentFloor;
        }
        private void moveDown() {
            if (currentFloor - 1 >= minFloor) {
                currentFloor--;
            }
        }
        private void moveUp() {
            if (currentFloor + 1 <= maxFloor) {
                currentFloor++;
            }
        }
        public void move(int floor){
            if (floor < minFloor || floor > maxFloor) {
                Console.WriteLine($"Ошибка, указанный этаж {floor} не входит в диапазон доступных этажей.");
                return;
            }
            Action direct;
            if (floor < currentFloor) {
                direct = moveDown;
            }
            else if (floor > currentFloor) {
                direct = moveUp;
            }
            else { return; }
            while (currentFloor != floor) {
                direct();
                Console.WriteLine(currentFloor);
            }
        }
    }
}