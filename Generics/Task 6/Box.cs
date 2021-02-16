using System;

namespace ConsoleApp1
{
    public class Box<T> 
    where T: IComparable
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get;
            private set;
        }

        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueTypeName = valueType.FullName;

            return $"{valueTypeName}: {this.Value}";
        }
    }
}