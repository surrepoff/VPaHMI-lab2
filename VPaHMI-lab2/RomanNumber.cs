using System;

namespace VPaHMI_lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        //Конструктор получает число n, которое должен представлять объект класса
        public RomanNumber(ushort n)
        {
            throw new NotImplementedException();
        }

        //Сложение римских чисел
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            throw new NotImplementedException();
        }

        //Вычитание римских чисел
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            throw new NotImplementedException();
        }

        //Умножение римских чисел
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            throw new NotImplementedException();
        }

        //Целочисленное деление римских чисел
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {
            throw new NotImplementedException();
        }

        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        //Реализация интерфейса IClonable
        public object Clone()
        {
            throw new NotImplementedException();
        }

        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
