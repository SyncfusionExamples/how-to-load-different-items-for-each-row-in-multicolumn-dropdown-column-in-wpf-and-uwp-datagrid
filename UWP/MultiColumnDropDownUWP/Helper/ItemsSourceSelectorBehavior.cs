using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColumnDropDownUWP
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
