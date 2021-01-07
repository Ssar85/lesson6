using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            killmenu();
        }

        static void Print ()
        {
            Console.WriteLine("Выводим список процессов...");
            foreach (Process proc in Process.GetProcesses())
            {
                Console.WriteLine($"Процесс id: {proc.Id} Name: {proc.ProcessName}");
            }
            
        }
        static void killbyname()
        {
            Console.WriteLine("введите имя процесса для завершения");
            Process[] name = Process.GetProcessesByName(Console.ReadLine());
            name[0].Kill();
            
        }
        static void killbyid()
        {
            Console.WriteLine("введите id процесса для завершения");
            Process id=Process.GetProcessById(Convert.ToInt32(Console.ReadLine()));
            id.Kill();

        }

        static void killmenu()
        {
            Console.WriteLine("Выберете пункт меню и нажмите Enter:");
            Console.WriteLine("1.Снять процесс по ID");
            Console.WriteLine("2.Снять процесс по Имени");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
                killbyid();
            if (menu == 2)
                killbyname();
            if (menu < 0 | menu > 2)
                Console.WriteLine("Введите 1 или 2... ");
                killmenu();

        }
    }
}
