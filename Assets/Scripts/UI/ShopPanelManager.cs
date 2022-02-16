using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopPanelManager : MonoBehaviour
{
    private bool isRunning = false;
    private bool isVisible = false;
    public Vector2 hidePos = new Vector2(0, -700);
    public Vector2 showPos = new Vector2(0, -425);

    public void StartChange()
    {
        if (!isRunning)
        {
            if (!isVisible)
            {
                StartCoroutine(changeState(showPos.y));
                isVisible = !isVisible;
            }
            else if (isVisible)
            {
                StartCoroutine(changeState(hidePos.y));
                isVisible = !isVisible;
            }
        }
    }

    IEnumerator changeState(float y)
    {
        isRunning = true;
        LeanTween.moveLocalY(gameObject, y, 0.5f);
        isRunning = false;
        yield return null;
    }

}
