using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class shopManager : MonoBehaviour
{
    public List<potions_SO> allPotions;
    public int shopAmt;
    public GameObject shopContainer;
    public TextMeshProUGUI infoContainer;

    public void enterShop()
    {
        for (int i = 0; i < shopAmt; i++)
        {
            GameObject newP = new GameObject();
            Image pImg = newP.AddComponent<Image>();
            itemData pData = newP.AddComponent<itemData>();
            pData.infoText = infoContainer;
            potions_SO randP = allPotions[Random.Range(0, allPotions.Count)];
            pData.pData = randP;
            pImg.sprite = pData.pData.icon;
            newP.transform.SetParent(shopContainer.transform, false);
        }
    }
}
