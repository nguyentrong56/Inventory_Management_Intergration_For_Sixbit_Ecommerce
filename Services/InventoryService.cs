using BlueFox.Models;
using BlueFox.Models.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BlueFox.Services
{
    public static class InventoryService
    {
        /// <summary>
        /// Find  inventory using itemID
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static Inventory FindItemByID(int itemID)
        {

            using (var context = new SixbitContext())
            {
                return context.Inventory.Where(x => x.ItemId == itemID).FirstOrDefault();
            }
        }


        /// <summary>
        /// Find inventories using product title
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>List of inventores which contain substring of item Name </returns>
        public static List<Inventory> FindItemByName(string itemName)
        {
            var searchList = new List<Inventory>();
            using (var context = new SixbitContext())
            {
                var list = context.Inventory.ToList();
                foreach (Inventory i in list)
                {
                    // Retrieve product titles from table Item because table Inventory in database does not contain product titles
                    i.Title = context.Items.Where(x => x.ItemId == i.ItemId).FirstOrDefault().Title;

                    //Check if itemName is a substring of inventory's title string
                    string[] wordArray = itemName.Split(' ');

                    // boolean substringCheck is true when all substrings  in itemName is in Inventory i's title
                    bool substringCheck = true;
                    foreach (string s in wordArray)
                    {
                        if (!i.Title.ToLower().Contains(s.ToLower()))
                        {
                            substringCheck = false;
                        }
                    }

                    if (substringCheck == true)
                    {
                        searchList.Add(i);
                    }

                }
                return searchList;

            }
        }


        /// <summary>
        /// Retrieve quantity of item being listed on Ebay account
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public static int? FindEBayListingQuantity(int itemID)
        {
            using (var context = new SixbitContext())
            {
                int? count = 0;
                List<Listings> result = context.Listings.Where(x => x.ItemId == itemID).ToList();
                foreach (Listings i in result)
                {
                    if (i.StatusId == 2000)
                    {
                        count += i.QtyRemaining;
                    }

                }
                return count;
            }
        }


        /// <summary>
        /// Update Inventory table in database when rows are modified
        /// </summary>
        /// <param name="list"></param>
        public static void UpdateInventory(ObservableCollection<InventoryDTO> list)
        {
            using (var context = new SixbitContext())
            {
                foreach (InventoryDTO i in list)
                {
                    // Member variable HasChange notifies if the row has been changed in View)

                    var inventory = context.Inventory.Where(x => x.ItemId == i.ItemID).FirstOrDefault();
                    inventory.ExternalQuantity = i.Quantity;
                    inventory.AmazonQuantity = i.QuantityOnAmazon;
                    inventory.FixedPrice = i.Price;
                    inventory.Sku = i.SKU;
                }
                context.SaveChanges();
            }
        }


    }
}
