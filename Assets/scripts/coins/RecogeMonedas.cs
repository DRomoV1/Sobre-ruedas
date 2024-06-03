using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogeMonedas : MonoBehaviour
{
    public CurrentsCoins currentsCoins;

    private void Start()
    {
        currentsCoins = GameManager.Instance.currentsCoins;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Moneda");
            ComandosSQLite.sharedInstance.pickCoin();
            currentsCoins.currentsCoins += 10;
            GameManager.Instance.recogerMoneda.Invoke();
            collision.gameObject.SetActive(false);
        }
    }
}
