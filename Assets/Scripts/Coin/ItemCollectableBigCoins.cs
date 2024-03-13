using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableBigCoins : ItemCollectableBase{
    protected override void Collect(){
        base.Collect();
        ItemManager.Instance.AddBigCoins();
    }
}
