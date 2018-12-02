using System;

namespace ClassLibrary3
{
    public class Column:Attribute
    {
        public string Name { get; private set; }
        public Type datatype { get ; private set; }

        public Column(string Name, Type datatype)
        {
            this.Name = Name;
            this.datatype = datatype;
        }
    }
}