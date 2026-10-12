using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class itemData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public potions_SO pData;
    public TextMeshProUGUI infoText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        infoText.text = pData.description;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        infoText.text = "";
    }
}
