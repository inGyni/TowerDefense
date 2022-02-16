using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
    [HideInInspector] public List<Vector3> positions;
    [HideInInspector] public BuildingManager bm;
    [HideInInspector] public AlertPanelManager alert;
    public GameObject towerPrefab;

    private void Start()
    {
        bm = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        alert = GameObject.Find("AlertPanel").GetComponent<AlertPanelManager>();
    }

    void OnMouseUpAsButton()
    {
        Vector3 pos = transform.position + Vector3.up;
        if (!positions.Contains(pos))
        {
            if(bm.CurrentBalance() > 0)
            {
                GameObject g = (GameObject)Instantiate(towerPrefab);
                g.transform.position = pos;
                positions.Add(pos);
                bm.ModifyPieces(-1);
            }
            else
            {
                alert.AlertMessage("You don't have enough building pieces!");
            }
        }
        else
        {
            alert.AlertMessage("You already placed a block there!");
        }
    }
}
