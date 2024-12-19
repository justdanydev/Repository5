using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{

    public interface IWorker
    {
        void Work(); 
        void TakeBreak(); 
    }

    public class Manager : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Менеджер управляет командой и решает задачи.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Менеджер отдыхает и пьет кофе.");
        }
    }
    public class Developer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Разработчик пишет код и тестирует его.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Разработчик отдыхает и смотрит видео на YouTube.");
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            Developer developer = new Developer();

            manager.Work();
            manager.TakeBreak();
            Console.WriteLine();

            developer.Work();
            developer.TakeBreak();
        }
    }
}
