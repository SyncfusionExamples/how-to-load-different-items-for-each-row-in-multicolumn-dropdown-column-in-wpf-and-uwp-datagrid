#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MultiColumnDropDownUWP
{
    public class ViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.PopulateData();
            _shipCities = CountryDetailsRepository.GetShipCities();
            CountryList = new List<string>(ShipCities.Keys);
        }
        
        private ObservableCollection<OrderDetails> _orderDatails;
        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderDetails> OrderDetails
        {
            get
            {
                return _orderDatails;
            }
            set
            {
                _orderDatails = value;
            }
        }

        Dictionary<string, ObservableCollection<ShipCityDetails>> _shipCities;
        /// <summary>
        /// Gets or sets the ship cities.
        /// </summary>
        /// <value>The ship cities.</value>
        public Dictionary<string, ObservableCollection<ShipCityDetails>> ShipCities
        {
            get
            {
                return _shipCities;
            }
            set
            {
                _shipCities = value;
            }
        }

        public List<string> CountryList { get; set; }

        Random r = new Random();
        public void PopulateData()
        {
            _orderDatails = new ObservableCollection<OrderDetails>();
            _orderDatails.Add(new OrderDetails(1000, "ALFKI", "Alice Mutton", 10, "Argentina", 101));
            _orderDatails.Add(new OrderDetails(1001, "FRANS", "NuNuCa Nub-Nougat-Creme", 15, "Austria", 106));
            _orderDatails.Add(new OrderDetails(1002, "MEREP", "Boston Crab Meat", 20, "Belgium", 111));
            _orderDatails.Add(new OrderDetails(1003, "FOLKO", "Raclette Courdavault", 25, "Brazil", 115));
            _orderDatails.Add(new OrderDetails(1004, "WARTH", "Alice Mutton", 20, "Canada", 120));
            _orderDatails.Add(new OrderDetails(1005, "LINOD", "NuNuCa Nub-Nougat-Creme", 17, "Denmark", 125));
            _orderDatails.Add(new OrderDetails(1006, "FOLIG", "Boston Crab Meat", 14, "Finland", 130));
            _orderDatails.Add(new OrderDetails(1007, "RISCU", "Raclette Courdavault", 11, "Italy", 134));
            _orderDatails.Add(new OrderDetails(1008, "FURIB", "Wimmers gute Semmelknodel", 7, "US", 138));
            _orderDatails.Add(new OrderDetails(1009, "BLONP", "Alice Mutton", 5, "Belgium", 112));
            _orderDatails.Add(new OrderDetails(1010, "BLONP", "NuNuCa Nub-Nougat-Creme", 3, "Brazil", 116));
            _orderDatails.Add(new OrderDetails(1011, "LINOD", "Boston Crab Meat", 7, "Denmark", 126));
            _orderDatails.Add(new OrderDetails(1012, "FOLIG", "Raclette Courdavault", 13, "Argentina", 102));
            _orderDatails.Add(new OrderDetails(1013, "LINOD", "Wimmers gute Semmelknodel", 12, "Canada", 121));
            _orderDatails.Add(new OrderDetails(1014, "RISCU", "Alice Mutton", 5, "Finland", 131));
            _orderDatails.Add(new OrderDetails(1015, "FURIB", "NuNuCa Nub-Nougat-Creme", 1, "US", 139));
            _orderDatails.Add(new OrderDetails(1016, "SEVES", "Boston Crab Meat", 6, "Austria", 107));
            _orderDatails.Add(new OrderDetails(1017, "FOLIG", "Raclette Courdavault", 9, "Italy", 135));
            _orderDatails.Add(new OrderDetails(1018, "LINOD", "Wimmers gute Semmelknodel", 4, "Denmark", 127));
            _orderDatails.Add(new OrderDetails(1019, "RISCU", "Konbu", 2, "Finland", 132));
            _orderDatails.Add(new OrderDetails(1020, "SEVES", "Alice Mutton", 3, "Argentina", 103));
            _orderDatails.Add(new OrderDetails(1021, "FURIB", "NuNuCa Nub-Nougat-Creme", 8, "Austria", 108));
            _orderDatails.Add(new OrderDetails(1022, "SEVES", "Boston Crab Meat", 18, "Belgium", 113));
            _orderDatails.Add(new OrderDetails(1023, "LINOD", "Raclette Courdavault", 4, "Brazil", 117));
            _orderDatails.Add(new OrderDetails(1024, "SEVES", "Konbu", 9, "Canada", 122));
            _orderDatails.Add(new OrderDetails(1025, "FURIB", "Alice Mutton", 10, "Denmark", 128));
            _orderDatails.Add(new OrderDetails(1026, "SEVES", "NuNuCa Nub-Nougat-Creme", 17, "Finland", 133));
            _orderDatails.Add(new OrderDetails(1027, "BLONP", "Boston Crab Meat", 15, "Italy", 136));
            _orderDatails.Add(new OrderDetails(1028, "FOLIG", "Raclette Courdavault", 13, "US", 140));
            _orderDatails.Add(new OrderDetails(1029, "LINOD", "Konbu", 5, "Belgium", 114));
            _orderDatails.Add(new OrderDetails(1030, "SEVES", "Alice Mutton", 3, "Brazil", 118));
            _orderDatails.Add(new OrderDetails(1031, "BLONP", "NuNuCa Nub-Nougat-Creme", 17, "Denmark", 129));
            _orderDatails.Add(new OrderDetails(1032, "SEVES", "Boston Crab Meat", 19, "Argentina", 104));
            _orderDatails.Add(new OrderDetails(1033, "LINOD", "Raclette Courdavault", 4, "Canada", 123));
            _orderDatails.Add(new OrderDetails(1034, "SEVES", "Wimmers gute Semmelknodel", 12, "Finland", 133));
            _orderDatails.Add(new OrderDetails(1035, "SEVES", "Alice Mutton", 11, "US", 141));
            _orderDatails.Add(new OrderDetails(1036, "FURIB", "NuNuCa Nub-Nougat-Creme", 7, "Austria", 109));
            _orderDatails.Add(new OrderDetails(1037, "SEVES", "Boston Crab Meat", 10, "Italy", 137));
            _orderDatails.Add(new OrderDetails(1038, "LINOD", "Alice Mutton", 1, "Denmark", 126));
            _orderDatails.Add(new OrderDetails(1039, "FOLIG", "NuNuCa Nub-Nougat-Creme", 13, "Finland", 132));
        }
        string[] ProductName = new string[]
       {
            "Alice Mutton",
            "NuNuCa Nub-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute Semmelknodel",
            "Konbu"
       };
        string[] CustomerID = new string[]
      {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG"
      };
    }
}
