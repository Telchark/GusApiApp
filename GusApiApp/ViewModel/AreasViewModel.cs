using GusApiApp.Data;
using GusApiApp.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GusApiApp.ViewModel
{
    public class AreasViewModel : ViewModelBase
    {
        private readonly IAreaDataProvider _areaDataProvider;

        public AreasViewModel(IAreaDataProvider areaDataProvider)
        {
            _areaDataProvider = areaDataProvider;
        }

        public ObservableCollection<Area> Areas { get; } = new();

        public override async Task LoadAsync()
        {
            if (Areas.Any())
            {
                return;
            }

            var areas = await _areaDataProvider.GetAllAsync();
            if (areas is not null)
            {
                foreach (var area in areas)
                {
                    Areas.Add(area);
                }
            }
        }
    }
}
