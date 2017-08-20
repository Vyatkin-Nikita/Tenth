using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenth
{

    class MyList //Класс для однонаправленного списка
    {
        private double data;//иформационное поле элемента списка
        private MyList next;//адресное поле элемента списка (указывает на следующий элемент)
        public double Data
        {
            get { return data; }
            set { data = value; }
        }//Свойство data
        public MyList Next
        {
            get { return next; }
            set { next = value; }
        }//Свойство next
        public MyList()//Создание пустого элемента списка
        {
            data = 0;
            next = null;
        }
        public MyList(double d)//Создание элемента списка
        {
            data = d;
            next = null;
        }
        public void Add(double info)//Добавление элемента с указанным информационным полем в конец списка
        {
            MyList end = this;
            while (end.next != null)
            {
                end = end.next;
            }
            end.next = new MyList(info);
          
        }
        public void ShowList()//Показать список
        {
            if (this == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            MyList p = this;
            while (p != null)
            {
                Console.Write(p + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public double FindEnd()//Нахождение информационного поля последнего элемента списка
        {
            MyList end = this;
            while (end.next != null)
            {
                end = end.next;
            }
            return end.Data;
        }
        public override string ToString()
        {
            return data + " ";
        }


    }
}
