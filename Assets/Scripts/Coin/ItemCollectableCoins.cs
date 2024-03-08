using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoins : ItemCollectableBase{
    
    protected override void Collect(){
        base.Collect();
        ItemManager.Instance.AddCoins();
    }
}