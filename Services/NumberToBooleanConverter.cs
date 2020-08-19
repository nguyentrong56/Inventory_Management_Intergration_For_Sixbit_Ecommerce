using BlueFox.Models.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace BlueFox.Services
{
    public class NumberToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                bool ToReturn = false;
                var inventoryObj = (InventoryDTO)value;
                if(inventoryObj.Quantity == 0 && inventoryObj.QuantityOnAmazon > 0)
                {
                    ToReturn = true;
                }

                else if(inventoryObj.Quantity == 0 && inventoryObj.QuantityOnEbay > 0)
                {
                    ToReturn = true;
                }


                return ToReturn;
            }
            catch
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("THe converter is only one way");
        }
    }
}
