using System;
namespace HolisticWare.Math
{
    public static class TypeExtensionsNumeric
    {
        public static bool IsNumeric(this Type type)
        {
            #if NETSTANDARD1_3
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return Nullable.GetUnderlyingType(type).IsNumeric();
                        //return IsNumeric(Nullable.GetUnderlyingType(type));
                    }
                    return false;
                default:
                    return false;
            }
            #endif

            return IsNumericType(type);
        }

        private static readonly System.Collections.Generic.HashSet<Type> NumericTypes; 


        static TypeExtensionsNumeric()
        {
            NumericTypes = new System.Collections.Generic.HashSet<Type>
            {
                typeof(int),
                typeof(double),
                typeof(decimal),
                typeof(long),
                typeof(short),
                typeof(sbyte),
                typeof(byte),
                typeof(ulong),
                typeof(ushort),
                typeof(uint),
                typeof(float)
            };

            return;
        }

        public static bool IsNumericType(Type myType)
        {
         return NumericTypes.Contains(Nullable.GetUnderlyingType(myType) ?? myType);
        }
    }
}
