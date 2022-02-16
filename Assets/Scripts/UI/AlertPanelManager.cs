using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlertPanelManager : MonoBehaviour
{
    private bool isRunning = false;
    public Vector2 showPos = new Vector2(0, 425);
    public Vector2 hidePos = new Vector2(0, 700);
    public TextMeshProUGUI text;

    public void AlertMessage(string alert)
    {
        text.text = alert;
        if (!isRunning)
        {
            StartCoroutine(movePosition(showPos.y, hidePos.y));
        }
    }

    IEnumerator movePosition(float y1, float y2)
    {
        isRunning = true;
        LeanTween.moveLocalY(gameObject, y1, 0.5f);
        yield return new WaitForSeconds(2);
        LeanTween.moveLocalY(gameObject, y2, 0.5f);
        isRunning = false;
        yield return null;
    }

}