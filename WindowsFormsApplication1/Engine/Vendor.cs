using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml;

namespace Engine
{
    public class Vendor : INotifyPropertyChanged
    {
        public string Name { set; get; }

        public BindingList<InventoryItem> Inventory { private set; get; }

        public Vendor(string name)
        {
            Name = name;
            Inventory = new BindingList<InventoryItem>();
        }

        public void AddItemToInventory(Item itemToAdd, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(
                ii => ii.Details.ID == itemToAdd.ID);

            if(item == null)
            {
                // They didn't have item in inventory
                Inventory.Add(new InventoryItem(itemToAdd, quantity));
            }
            else
            {
                // The have the item, so increase quantity
                item.Quantity += quantity;
            }

            OnPropertyChanged("Inventory");
        }

        public void RemoveItemFromInventory(Item itemToRemove, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(
                ii => ii.Details.ID == itemToRemove.ID);
            
            if(item == null)
            {
                // THe item is not in the inventory
                // TO-DO raise error
            }
            else
            {
                // They have it, so decrease quantity
                item.Quantity -= quantity;

                // Don't allow negative quantities
                if(item.Quantity < 0)
                {
                    item.Quantity = 0;
                }

                // If the quantity is zero, remove it from inventory
                if(item.Quantity == 0)
                {
                    Inventory.Remove(item);
                }

                // Notify the UI that the inventory has changed
                OnPropertyChanged("Inventory");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public string ToXmlString()
        {
            XmlDocument vendorData = new XmlDocument();

            // Create the top-level XML node
            XmlNode vendor = vendorData.CreateElement("Vendor");
            vendorData.AppendChild(vendor);

            // Create the "InventoryItem" child node to hold each InventoryItem node
            XmlNode inventoryItems = vendorData.CreateElement("InventoryItems");
            vendorData.AppendChild(inventoryItems);

            // Create an "InventoryItem" node for each item in the vendor's inventory
            foreach (InventoryItem item in this.Inventory)
            {
                XmlNode inventoryItem = vendorData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = vendorData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = vendorData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            return vendorData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }

        public static Vendor CreateVendorFromXmlString(string xmlVendorData)
        {
            try
            {
                XmlDocument vendorData = new XmlDocument();

                vendorData.LoadXml(xmlVendorData);

                Vendor vendor = new Vendor("Alan the NPC Merchant");

                foreach (XmlNode node in vendorData.SelectNodes(
                    "/Vendor/InventoryItems/InventoryItem"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    for (int i = 0; i < quantity; i++)
                    {
                        vendor.AddItemToInventory(World.ItemByID(id));
                    }
                }

                return vendor;
            }
            catch
            {
                // If there was an error with the XML data, return a default player object
                return Vendor.CreateDefaultVendor();
            }
        }

        public static Vendor CreateDefaultVendor()
        {
            Vendor vendor = new Vendor("Alan the NPC Merchant");

            vendor.AddItemToInventory(World.ItemByID(World.ITEM_ID_HEALING_POTION), 5);
            vendor.AddItemToInventory(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 5);
            vendor.AddItemToInventory(World.ItemByID(World.ITEM_ID_CLUB), 5);

            return vendor;
        }
    }
}
