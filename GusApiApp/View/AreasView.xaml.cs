using GusApiApp.Misc;
using System.ComponentModel;
using System.Windows.Controls;

namespace GusApiApp.View
{
    /// <summary>
    /// Interaction logic for AreasView.xaml
    /// </summary>
    public partial class AreasView : UserControl
    {
        public AreasView()
        {
            InitializeComponent();
        }

        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var desc = e.PropertyDescriptor as PropertyDescriptor;
            var att = desc.Attributes[typeof(ColumnNameAttribute)] as ColumnNameAttribute;
            if (att != null)
            {
                e.Column.Header = att.Name;
                if (desc.Name == "Name" || desc.Name == "Level_Name")
                    e.Column.Width = new DataGridLength(3, DataGridLengthUnitType.Star);
            }
        }
    }
}
