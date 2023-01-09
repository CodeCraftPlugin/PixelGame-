using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollecItem : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectItem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = ""+cherries;
            collectItem.Play();
        }
    }
}
