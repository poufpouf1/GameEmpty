//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Item
//{
//    public enum ItemType
//    {
//        Graine, 
//        Carotte,
//        CarotteCuite,
//        BouteilleV,
//        BouteilleR,
//        Arrosoir,
//    }

//    public ItemType itemType;
//    public int amount;

//    public Sprite GetSprite()
//    {
//        switch (itemType)
//        {
//            default:
//            case ItemType.Carotte: return ItemAssets.Instance.carotteSprite;
//            case ItemType.CarotteCuite: return ItemAssets.Instance.carotteCuiteSprite;
//            case ItemType.Graine: return ItemAssets.Instance.graineSprite;
//            case ItemType.Arrosoir: return ItemAssets.Instance.arrosoirSprite;
//            case ItemType.BouteilleV: return ItemAssets.Instance.bouteilleVSprite;
//            case ItemType.BouteilleR: return ItemAssets.Instance.bouteillePSprite;
//        }
//    }

//    public bool IsStackable()
//    {
//        switch(itemType)
//        {
//            default:
//            case ItemType.Graine:
//            case ItemType.Carotte:
//            case ItemType.CarotteCuite:
//                return true;
//            case ItemType.Arrosoir:
//            case ItemType.BouteilleV:
//            case ItemType.BouteilleR:
//                return false;
//        }
//    }
//}
