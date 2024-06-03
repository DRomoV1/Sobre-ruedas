using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MonedaUI : MonoBehaviour
{
    public CurrentsCoins currentsCoins;
    private TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = currentsCoins.totalCoins.ToString();
    }
}
