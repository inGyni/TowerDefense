using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingManager : MonoBehaviour
{
    private int buildingPieces = 5;
    public TextMeshProUGUI text;

    private void Awake()
    {
        UpdateDisplay();
    }

    public int CurrentBalance()
    {
        UpdateDisplay();
        return buildingPieces;
    }

    public void ModifyPieces(int modifyValue)
    {
        buildingPieces = ((buildingPieces + modifyValue >= 0) ? buildingPieces + modifyValue : 0);
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        text.text = buildingPieces.ToString();
    }
}
