using System;

namespace Core.Math
{
    public class Arithmetic<T>
    {
        protected static readonly Func<T, T, T> Addition;
        protected static readonly Func<T, T, T> Substraction;

        protected static readonly Func<T, T, T> Multiplication;
        protected static readonly Func<T, T, T> Division;

        static Arithmetic()
        {
            Arithmetic<byte>.Addition = (x, y) => x + y;
            Arithmetic<byte>.Substraction = (x, y) => x - y;

            Arithmetic<byte>.Multiplication = (x, y) => x * y;
            Arithmetic<byte>.Division = (x, y) => x / y;

        }
    }
}
