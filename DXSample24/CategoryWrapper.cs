using System;
using DevExpress.Xpf.Bars.Native;

namespace DXSample24
{
    public class CategoryWrapper
    {
        public CategoryWrapper(Category category)
        {
            Category = category;
        }

        private Category Category { get; }

        public String DisplayText => Category?.Name ?? "<no category>";

        public Int32? Value => Category?.Id;
    }
}