using System.Collections.Generic;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;

namespace DXSample24
{
    public class CategoryEditSettings : ComboBoxEditSettings
    {
        public CategoryEditSettings()
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
            this.IsTextEditable = false;
            this.DisplayMember = nameof(CategoryWrapper.DisplayText);
            this.ValueMember = nameof(CategoryWrapper.Value);

            this.SelectItemWithNullValue = true;
        }

        private List<CategoryWrapper> Entries { get; }
    }
}