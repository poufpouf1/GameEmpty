//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player : MonoBehaviour
//{
//    [SerializeField] private UI_Inventory uiInventory;

//    private Inventory inventory;

//    // Start is called before the first frame update
//    void Awake()
//    {
//        inventory = new Inventory();
//        uiInventory.SetInventory(inventory);
//    }

//    void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.tag == "SeedGiver")
//        {
//            inventory.AddItem(new Item { itemType = Item.ItemType.Graine, amount = 1 });
//            Debug.Log("Graine");
//            Debug.Log(inventory.itemList.Count);
//        }

//        if (collision.gameObject.tag == "Soil")
//        {
//            bool asGraine = false;
            
//            Debug.Log("Action: planter");
//            foreach (Item inventoryItem in inventory.itemList)
//            {
//                if (inventoryItem.itemType == Item.ItemType.Graine)
//                {
//                    Debug.Log("ça plante");
//                    asGraine = true;
//                }
//            }
//            if(asGraine)
//            {
//                inventory.RemoveItem(inventoryItem);
//            }
//        }

//        if (collision.gameObject.tag == "Puit")
//        {
//            Debug.Log("Action: Remplir");
//            foreach (Item inventoryItem in inventory.itemList)
//            {
//                if (inventoryItem.itemType == Item.ItemType.BouteilleV)
//                {
//                    Debug.Log("ça rempli");
//                    inventory.RemoveItem(inventoryItem);
//                    inventory.AddItem(new Item { itemType = Item.ItemType.BouteilleR, amount = 1 });
//                }
//            }
//        }
//    }
//}
