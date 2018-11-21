using System;

namespace DXSample24
{
    public class DummyRow
    {
        private static Int32 _instanceCounter = 0;
        private static readonly Random _rng = new Random();

        public DummyRow(Category category)
        {
            Caption = $"Row #{_instanceCounter++}";
            Random = _rng.Next();
            Category = category?.Id;
        }

        public String Caption { get; set; }

        public Int32 Random { get; set; }

        public Int32? Category { get; set; }
    }
}