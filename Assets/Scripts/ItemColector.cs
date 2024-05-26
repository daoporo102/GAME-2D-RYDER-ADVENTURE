using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColector : MonoBehaviour
{
    private int fruits = 0;
    [SerializeField] private Text fruitsText;

    [SerializeField] private AudioSource collectItemSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fruits"))
        {
            collectItemSoundEffect.Play();
            Destroy(collision.gameObject);
            fruits++;
            fruitsText.text = "Item collected: " + fruits;
        }
    }


}
