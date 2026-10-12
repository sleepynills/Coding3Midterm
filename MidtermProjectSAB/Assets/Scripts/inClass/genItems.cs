using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class genItems : MonoBehaviour
{
    //calling the contructor of the items class when I am declaring it as a variable
    //the constructor loads in the default values of the `items` class
    public GameObject itemContainer;
    public List<potions_SO> allPotions;

    public void generateItems()
    {
        GameObject newGenItem = new GameObject();
        Image img = newGenItem.AddComponent<Image>();
        potions_SO newP = allPotions[Random.Range(0, allPotions.Count)];
        img.sprite = newP.icon;
        newGenItem.transform.SetParent(itemContainer.transform, false);
    }

}
