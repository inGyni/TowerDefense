using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EconomyManager : MonoBehaviour
{
    private int balance;
    public TextMeshProUGUI text;

    private void Awake()
    {
        UpdateDisplay();
    }

    public int CurrentBalance()
    {
        UpdateDisplay();
        return balance;
    }

    public void ModifyBalance(int modifyValue)
    {
        balance = ((balance + modifyValue >= 0) ? balance + modifyValue : 0);
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        text.text = balance.ToString();
    }
}
