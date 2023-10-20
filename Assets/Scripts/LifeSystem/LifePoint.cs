using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LifePoint
{
    public bool activeLife;
    public Image image;
    public void SetLife(bool value){
        if(!value){
            activeLife = false;
            image.enabled = false;
        }
        else if(value){
            activeLife = true;
            image.enabled = true;
        }
    }
}
