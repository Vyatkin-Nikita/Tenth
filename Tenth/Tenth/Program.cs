using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenth
{
    /*
     * Программа создаёт однонаправленный список из n указанных элементов
     * и на их основе строит новый одноправленный список по принципу
     * a1-an, a2-an, ... an-1 - an 
     */
    class Program
    {
        static MyList beg;//Певрый элемент вводимой последовательности
        static int n;//Число n
        static int VvodProverka(int mogr = 0, int bogr = 0)//Проверка вводимых с клавиатуры чисел (целых), mogr и bogr - минимально и максимально возможные значения числа
        {
            bool ok;
            int n;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok) { Console.WriteLine("Ошибка. Неверный формат данных. Повторите ввод."); continue; }
                if ((n < mogr) && (bogr < mogr)) { Console.WriteLine("Ошибка. Число должно быть больше или равно {0} . Повторите ввод.", mogr); ok = false; continue; }
                if ((n < mogr) && (mogr != 0) || ((n > bogr) && (bogr != 0))) { Console.WriteLine("Ошибка. Число должно находится в пределах от {0} до {1} . Повторите ввод.", mogr, bogr); ok = false; }

            } while (!ok);
            Console.WriteLine();
            return n;
        }
        static double VvodProverka()//Проверка действительных чисел
        {
            bool ok;
            double n;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out n);
                if (!ok) { Console.WriteLine("Ошибка. Неверный формат данных. Повторите ввод.");}
            } while (!ok);
            Console.WriteLine();
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            n = VvodProverka(2);

            Console.WriteLine("Введите 1-й элемент");
            beg = new MyList(VvodProverka());//Добавление первого элемента последовательности
            for (int i = 2; i <= n; i++)//Добавление остальных элементов последовательности
            {
                Console.WriteLine("Введите {0}-й элемент", i);
                beg.Add(VvodProverka());
            }

            Console.Clear();
            Console.WriteLine("Введённая последовательность");
            beg.ShowList();//Вывод в консоль введённой последовательности

            double ListEnd = beg.FindEnd();//Выевление последнего элемента последовательности

            MyList Slide = beg;//По порядку принимает значение всех элементов последовательности (кроме последнего)
            Console.WriteLine("Искомая последовательность");
            while (Slide.Next != null)//Вычисление и вывод на экран искомой последовательности
            {
                double t = Slide.Data - ListEnd;//Значение текущего элемента минус значение последнего
                Console.Write(t + " ");
                Slide = Slide.Next;
            }
            Console.ReadLine();
        }
    }
}
