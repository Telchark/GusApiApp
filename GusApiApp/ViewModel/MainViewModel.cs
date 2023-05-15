using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusApiApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(AreasViewModel areasViewModel)
        {
            AreasViewModel = areasViewModel;
        }
        public AreasViewModel AreasViewModel { get; }

        public async override Task LoadAsync()
        {
            if (AreasViewModel is not null)
            {
                await AreasViewModel.LoadAsync();
            }
        }
    }
}
