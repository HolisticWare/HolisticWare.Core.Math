using System;

namespace HolisticWare.Math
{
    public struct Numeric<T> : HolisticWare.Math.INumeric<T>  
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
