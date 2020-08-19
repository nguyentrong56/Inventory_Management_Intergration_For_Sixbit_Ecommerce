using BlueFox.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Dynamic;
using System.ComponentModel;
using Prism.Commands;
using BlueFox.Models.DTO;
using BlueFox.Services;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BlueFox.ViewModels
{
    public class InventoryViewModel : INotifyPropertyChanged
    {
        private ICommand updateButtonCommand
        {
            get;
            set;
        }

        private ICommand refreshButtonCommand
        {
            get;
            set;
        }



        private bool canExecute = true;


        public ObservableCollection<InventoryDTO> InventoryList
        {
            get;
            set;

        }

        public string _s;

        private readonly ObservableCollection<InventoryDTO> _result = new ObservableCollection<InventoryDTO>();
        public ObservableCollection<InventoryDTO> Result
        {
            get
            {
                return _result;
            }
        }
        public string Search
        {
            get 
            {
                return _s; 
            }
            set 
            { 
                _s = value;
                NotifyPropertyChanged("Search");
                GetResult(_s);
                
            }
        }
        private InventoryDTO selectedInventory;
        public InventoryDTO SelectedInventory
        {
            get { return selectedInventory; }
            set
            {
                selectedInventory = value;
                NotifyPropertyChanged("SelectedInventory");
            }
        }

        public string Update
        {
            get
            {
                return "Update";
            }
        }

        public DelegateCommand<object> MyCommand { get; private set; }

        public InventoryViewModel()
        {
            _s = "";
            InventoryList = new ObservableCollection<InventoryDTO>();
            GetResult(_s);


             MyCommand = new DelegateCommand<object>(Execute);
            UpdateButtonCommand = new RelayCommand(SaveChanges, param => this.canExecute);
            RefreshButtonCommand = new RelayCommand(Refresh, param => this.canExecute);
        }

        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }

        public void Execute(object inventory)
        {
            SelectedInventory = (InventoryDTO)inventory;
        }



        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }

   

        public event PropertyChangedEventHandler PropertyChanged;

        
        public void GetResult(string itemName)
        {
            InventoryList.Clear();
            Task.Factory.StartNew(() =>
            {
                return InventoryService.FindItemByName(itemName);
            }).ContinueWith(task =>
            {
               
                foreach (Inventory result in task.Result)
                {
                    var quantityOnEbay = InventoryService.FindEBayListingQuantity(result.ItemId);
                    bool potentialOversold = false;
                    if((result.ExternalQuantity == 0 && result.AmazonQuantity >0) || (result.ExternalQuantity == 0 && quantityOnEbay >0))
                    {
                        potentialOversold = true;
                    }
                    var resultDTO = new InventoryDTO
                    {
                        ItemID = result.ItemId,
                        SKU = result.Sku,
                        Title = result.Title,
                        Quantity = result.ExternalQuantity,
                        Price = result.FixedPrice,
                        QuantityOnEbay = quantityOnEbay,
                        QuantityOnAmazon = result.AmazonQuantity,
                        PotentialOversold = potentialOversold 

                    };
                    InventoryList.Add(resultDTO);
                }

            },
            System.Threading.CancellationToken.None,
            TaskContinuationOptions.None,
            TaskScheduler.FromCurrentSynchronizationContext());
            
        }

        public ICommand UpdateButtonCommand
        {
            get
            {
                return updateButtonCommand;
            }

            set
            {
                updateButtonCommand = value;
                GetResult("");
            }

        }

        public ICommand RefreshButtonCommand
        {
            get
            {
                return refreshButtonCommand;
            }

            set
            {
                refreshButtonCommand = value;

            }
        }
            public void SaveChanges(object obj)
        {
            var tempList = new ObservableCollection<InventoryDTO>();
            foreach (InventoryDTO i in InventoryList)
            {
                if(i.HasChange == true)
                {
                    tempList.Add(i);
                }
                
            }
            InventoryService.UpdateInventory(tempList);
            MessageBox.Show("Updated");
        }

        public void Refresh(object obj)
        {
            GetResult(_s);
            
        }

 

        public void ShowPicture(object sender, RoutedEventArgs e)
        {
            // Create Image and set its width and height  
            Image dynamicImage = new Image();
            dynamicImage.Width = 300;
            dynamicImage.Height = 200;

            // Create a BitmapSource  
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Books\Book WPF\How do I\ImageSample\ImageSample\Flower.JPG");
            bitmap.EndInit();

            // Set Image.Source  
            dynamicImage.Source = bitmap;

        }

 
    }
}
    

