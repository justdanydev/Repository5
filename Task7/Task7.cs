using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public abstract class Device
    {
        public abstract void TurnOn();
    }
    public class Computer : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Загрузка операционной системы...");
            Console.WriteLine("Компьютер включен.");
        }
    }

    public class Printer : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Проверка подключения...");
            Console.WriteLine("Принтер включен и готов к работе.");
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Computer computer = new Computer();
            Printer printer = new Printer();

            computer.TurnOn();
            Console.WriteLine();
            printer.TurnOn();
        }
    }
}
