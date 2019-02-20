using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler
{
    //changes the sprite when moused over

    public ChangeScript cS;
    public int aC;

    public void OnPointerEnter(PointerEventData eventData)
    {
        cS.a = aC;
    }
}