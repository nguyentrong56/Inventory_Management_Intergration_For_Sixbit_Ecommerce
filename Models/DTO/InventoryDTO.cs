using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Text;

namespace BlueFox.Models.DTO
{
    public class InventoryDTO : INotifyPropertyChanged
    {
        int _itemID;
        string _sku;
        string _title;
        int? _quantity;
        int? _ebayquantity;
        int? _amazonQuantity;
        decimal _price;
        bool _hasChanged = false;
        bool _potentialOversold = false;

        public int ItemID
        {
            get { return _itemID; }
            set
            {
                _itemID = value;
                OnPropertyChanged("ItemID");
            }

        }
        public string SKU
        {
            get { return _sku; }
            set
            {
                _sku = value;
          
                OnPropertyChanged("SKU");
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
           
                OnPropertyChanged("Title");
            }
        }

        public int?  Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
               
                OnPropertyChanged("Quantity");
            }
        }

        public int? QuantityOnEbay
        {
            get
            {
                return _ebayquantity;
            }

            set
            {
                _ebayquantity = value;

                OnPropertyChanged("QuantityOnEbay");
            }
        }

        public int? QuantityOnAmazon
        {
            get
            {
                return _amazonQuantity;
            }

            set
            {
                _amazonQuantity = value;
                OnPropertyChanged("QuantityOnAmazon");
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
               
                OnPropertyChanged("Price");
                    
            }
        }

        public bool HasChange
        {
            get
            {
                return _hasChanged;
            }
            set
            {
                _hasChanged = value;
               
            }
        }

        public bool PotentialOversold
        {
            get
            {
                return _potentialOversold;
            }
            set
            {
                _potentialOversold = value;
            }
        }
          

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.HasChange = true;
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
