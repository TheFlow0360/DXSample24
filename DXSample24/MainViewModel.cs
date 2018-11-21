using System;
using System.Collections.Generic;
using DevExpress.Mvvm;
using DevExpress.Xpf.Editors.Settings;

namespace DXSample24
{
    public class MainViewModel : ViewModelBase
    {
        public List<DummyRow> GridItems
        {
            get => GetProperty(() => GridItems);
            set => SetProperty(() => GridItems, value);
        }

        public CategoryWrapper SelectedItem
        {
            get => GetProperty(() => SelectedItem);
            set
            {
                SetProperty(() => SelectedItem, value);
                HandleSelected();
            }
        }

        public String Output
        {
            get => GetProperty(() => Output);
            set => SetProperty(() => Output, value);
        }

        public MainViewModel()
        {
            GridItems = new List<DummyRow>();
            var rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                var j = rng.Next(-1, Category.AllCategories.Count);
                GridItems.Add(new DummyRow(j >= 0 ? Category.AllCategories[j] : null));
            }
        }

        private void HandleSelected()
        {
            Output = $"Selected item now is {SelectedItem.DisplayText}";
        }
    }
}