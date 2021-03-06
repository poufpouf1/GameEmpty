//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Inventory
//{
//    public event EventHandler OnItemListChanged;
//    public List<Item> itemList;

//    public Inventory()
//    {
//        itemList = new List<Item>();

//        AddItem(new Item { itemType = Item.ItemType.BouteilleV, amount = 1 });

//        Debug.Log(itemList.Count);
//    }

//    public void AddItem(Item item)
//    {
//        if(item.IsStackable())
//        {
//            Debug.Log("Bon début");
//            bool itemAlreadyInInventory = false;
//            foreach(Item inventoryItem in itemList)
//            {
//                if(inventoryItem.itemType == item.itemType)
//                {
//                    inventoryItem.amount += item.amount;
//                    itemAlreadyInInventory = true;
//                }
//            }
//            if(!itemAlreadyInInventory)
//            {
//                itemList.Add(item);
//            }
//        }
//        else
//        {
//            itemList.Add(item);
//        }
//        OnItemListChanged?.Invoke(this, EventArgs.Empty);
//    }

//    public void RemoveItem(Item item)
//    {

//        if (item.IsStackable())
//        {
//            Item itemInInventory = null;
//            foreach (Item inventoryItem in itemList)
//            {
//                if (inventoryItem.itemType == item.itemType)
//                {
//                    inventoryItem.amount -= item.amount;
//                    itemInInventory = inventoryItem;
//                }
//            }
//            if (itemInInventory != null && itemInInventory.amount <= 0)
//            {
//                itemList.Remove(itemInInventory);
//            }
//        }
//        else
//        {
//            itemList.Remove(item);
//        }
//        OnItemListChanged?.Invoke(this, EventArgs.Empty);
//    }

//    public List<Item> GetItemList()
//    {
//        return itemList;
//    }

//}
