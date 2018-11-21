using System;
using System.Collections.Generic;

namespace DXSample24
{
    public class Category
    {
        public static List<Category> AllCategories { get; } = new List<Category>();

        public static void CreateCategory(String name)
        {
            AllCategories.Add(new Category(name));
        }

        private static Int32 _instanceCounter = 0;

        public Category(String name)
        {
            Id = _instanceCounter++;
            Name = name;
        }

        public Int32 Id { get; set; }

        public String Name { get; set; }
    }
}