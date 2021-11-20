using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public GameObject gate;
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Destroy(gate.gameObject);
            Destroy(this.gameObject);
            Debug.Log("Uma Chave foi Usada !");
        }
    }
}