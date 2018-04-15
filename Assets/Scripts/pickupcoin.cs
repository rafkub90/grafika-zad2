using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickupcoin : MonoBehaviour
{

    public Text wynik;

    // For now just destroy the coin if the player runs into
    // it. Could play a sound, add to a score or more here later!
    void OnTriggerEnter2D(Collider2D other)
    {
    //    if (other.gameObject.CompareTag("Player"))
    //    {



    //        Destroy(this.gameObject);
    //        Debug.Log("Coin was picked up");
        }
    }

