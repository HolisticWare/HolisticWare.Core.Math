using System;

namespace HolisticWare.Math
{
    public interface INumeric<T>
        :   
            IComparable, 
            IComparable<T>, // T = {ushort, float, 
            //IConvertible,   // .net standard 1.3
            // IEquatable<T>, // T = {ushort, float, 
            IFormattable
    {
    }
}
