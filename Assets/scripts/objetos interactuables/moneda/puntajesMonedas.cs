using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntajesMonedas : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        GameManager.Instance.recogerMoneda += UpdateUI;
    }

    private void OnDisable()
    {
        GameManager.Instance.recogerMoneda -= UpdateUI;
    }
    public void UpdateUI()
    {
        textMesh.text = GameManager.Instance.currentsCoins.currentsCoins.ToString();
    }
}
