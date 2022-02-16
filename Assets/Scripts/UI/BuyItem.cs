using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyItem : MonoBehaviour
{
    private EconomyManager em;
    private BuildingManager bm;
    public TextMeshProUGUI text;
    private bool isRunning = false; 
    public AlertPanelManager alert;

    private void Start()
    {
        em = GameObject.Find("EconomyManager").GetComponent<EconomyManager>();
        bm = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        alert = GameObject.Find("AlertPanel").GetComponent<AlertPanelManager>();
    }

    public void BuyPiece()
    {
        if (!isRunning)
        {
            if (em.CurrentBalance() < 100)
            {
                alert.AlertMessage("Not enough balance");
            }
            else
            {
                em.ModifyBalance(-100);
                bm.ModifyPieces(1);
            }
        }
    }
}
