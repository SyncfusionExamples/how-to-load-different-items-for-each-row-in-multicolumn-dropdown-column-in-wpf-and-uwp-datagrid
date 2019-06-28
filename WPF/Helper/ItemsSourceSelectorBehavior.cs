using Syncfusion.UI.Xaml.Grid;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

namespace MultiColumnDropDown
{
    /// <summary>
    /// Implementation class for ItemsSourceSelector interface
    /// </summary>
    public class ItemsSourceSelector : IItemsSourceSelector
    {
        public IEnumerable GetItemsSource(object record, object dataContext)
        {
            if (record == null)
                return null;

            var orderinfo = record as OrderDetails;
            var countryName = orderinfo.ShipCountry;

            var viewModel = dataContext as ViewModel;

            //Returns ShipCity collection based on ShipCountry.
            if (viewModel.ShipCities.ContainsKey(countryName))
            {
                ObservableCollection<ShipCityDetails> shipCities = null;
                viewModel.ShipCities.TryGetValue(countryName, out shipCities);
                return shipCities.ToList();
            }
            return null;
        }
    }
}
