﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(100,100,100, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
