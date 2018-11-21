using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Helpers;
using DevExpress.Xpf.Editors.Settings;

namespace DXSample24
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // create the available categories
            Category.CreateCategory("Category A");
            Category.CreateCategory("Category B");
            Category.CreateCategory("Category C");

            // register category EditSettings
            EditorSettingsProvider.Default.RegisterUserEditor2(
                typeof(CategoryControl),
                typeof(CategoryEditSettings),
                optimized => optimized ? new InplaceBaseEdit() : (IBaseEdit)Activator.CreateInstance(typeof(CategoryControl)),
                () => (BaseEditSettings)Activator.CreateInstance(typeof(CategoryEditSettings)));
        }
    }
}
