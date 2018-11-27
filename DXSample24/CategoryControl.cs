using System.Collections.Generic;
using DevExpress.Xpf.Editors;

namespace DXSample24
{
    public class CategoryControl : ComboBoxEdit
    {
        public CategoryControl()
        {
            Entries = new List<CategoryWrapper>
            {
                new CategoryWrapper(null)
            };

            foreach (var category in Category.AllCategories)
            {
                Entries.Add(new CategoryWrapper(category));
            }

            this.ItemsSource = Entries;
            this.ApplyItemTemplateToSelectedItem = true;
            this.IsTextEditable = false;
            this.DisplayMember = nameof(CategoryWrapper.DisplayText);
            this.ValueMember = nameof(CategoryWrapper.Value);

            this.SelectItemWithNullValue = true;
        }

        private List<CategoryWrapper> Entries { get; }
    }
}