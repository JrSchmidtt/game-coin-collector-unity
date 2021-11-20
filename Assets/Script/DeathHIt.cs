using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHIt : MonoBehaviour
{
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER !");
            GetComponent<AudioSource>().Play();
        }
    }
}
