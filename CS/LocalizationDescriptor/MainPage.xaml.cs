using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace LocalizationDescriptor {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            view.RuntimeLocalizationStrings.Add(new RuntimeStringIdInfo(
                GridControlRuntimeStringId.GridGroupPanelText,
                "To group by a column, drag its header here"));
            List<string> source = new List<string>() { "test string" };
            grid.DataSource = new ProductList();
        }

        private void view_Loaded(object sender, RoutedEventArgs e) {
            grid.View.ShowColumnChooser();
        }
    }
}
