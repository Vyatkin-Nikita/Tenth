using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenth
{

        class MyList //Класс для однонаправленного списка
        {
            public int data;//иформационное поле элемента списка (int)
            public MyList next;//адресное поле элемента списка (указывает на следующий элемент)
            public MyList()
            {
                data = 0;
                next = null;
            }//Создание пустого элемента  списка
            public MyList(int d)
            {
                data = d;
                next = null;
            }//Создание элемента списка
            public override string ToString()
            {
                return data + " ";
            }
            public static MyList MakeElem(int d)
            {
                MyList p = new MyList(d);
                return p;
            }//Создание элемента списка
            public static MyList DobNach(int size)
            {
                Random rnd = new Random();
                int info = rnd.Next(11);
                Console.WriteLine("Добавление числа {0}...", info);
                MyList beg = MakeElem(info);
                for (int i = 1; i < size; i++)
                {
                    info = rnd.Next(11);
                    Console.WriteLine("Добавление числа {0}...", info);
                    MyList p = MakeElem(info);
                    p.next = beg;
                    beg = p;
                }
                return beg;
            }//Создание списка добавлением элементов в начало списка
            public static MyList DobKon(int size)
            {
                Random rnd = new Random();
                int info = rnd.Next(11);
                Console.WriteLine("Добавление числа {0}...", info);
                MyList beg = MakeElem(info);
                MyList r = beg;
                for (int i = 1; i < size; i++)
                {
                    info = rnd.Next(11);
                    Console.WriteLine("Добавление числа {0}...", info);
                    MyList p = MakeElem(info);
                    r.next = p;
                    r = p;
                }
                return beg;
            }//Создание списка добавлением элементов в конец списка
            public static void ShowList(MyList beg)
            {
                if (beg == null)
                {
                    Console.WriteLine("Список пуст");
                    return;
                }
                MyList p = beg;
                while (p != null)
                {
                    Console.Write(p + " ");
                    p = p.next;

                }
                Console.WriteLine();
            }//Показать список
            public static MyList Dobavlenie(MyList beg, int number)
            {
                Random rnd = new Random();
                int info = rnd.Next(11);
                Console.WriteLine("Добавление числа {0}...", info);
                MyList NewElem = MakeElem(info);
                if (beg == null)
                {
                    beg = MakeElem(rnd.Next(11));
                    return beg;
                }
                if (number == 1)
                {
                    NewElem.next = beg;
                    beg = NewElem;
                    return beg;
                }
                MyList p = beg;
                for (int i = 1; i < number - 1 && p != null; i++)
                    p = p.next;
                if (p == null)
                {
                    Console.WriteLine("Ошибка! Длина списка меньше введённого номера");
                    return beg;
                }
                NewElem.next = p.next;
                p.next = NewElem;
                return beg;
            }//Добавление элемента в список на указанное место
            public static MyList Ydalenie(MyList beg, int number)
            {
                if (beg == null)
                {
                    return null;
                }
                if (number == 1)
                {
                    beg = beg.next;
                    return beg;
                }
                MyList p = beg;
                for (int i = 1; i < number - 1 && p != null; i++)
                    p = p.next;
                if (p == null)
                {
                    Console.WriteLine("Размер списка меньше введённого числа");
                    return beg;
                }
                p.next = p.next.next;
                return beg;
            }//Удаление элемента списка с указанным номером
            public static MyList Z1YdaleniePoslChetNum(MyList beg)
            {
                MyList p = beg;
                int count = 1, number = 0;
                if (beg == null)
                {
                    Console.WriteLine("Список пуст");
                    return beg;
                }
                do
                {
                    if (p.data % 2 == 0)
                        number = count;
                    p = p.next;
                    count++;
                } while (p != null);
                if (number == 0)
                {
                    Console.WriteLine("Нет элементов с чётным информационным полем");
                    return beg;
                }
                beg = Ydalenie(beg, number);

                return beg;
            }//Удаление последнего элемента списка с чётным информационным полем

        
    }
}
