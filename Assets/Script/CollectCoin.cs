using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    private int coinVault = 0;
    private int coinTotal;
    public Text score;
    public GameObject innerkey;

    private void Awake()
    {
        coinTotal = GameObject.FindGameObjectsWithTag("Moeda").Length;
    }

    private void OnCollisionEnter(Collision objeto)
    {
        if(objeto.gameObject.CompareTag("Moeda"))
        {
            Destroy(objeto.gameObject);
            coinVault = coinVault + 1;
            score.text = "SCORE : "+coinVault.ToString();
            Debug.Log(coinVault);
            GetComponent<AudioSource>().Play();

            if(coinVault == coinTotal)
            {
                innerkey.gameObject.SetActive(true);
            }
        }
    }
}
