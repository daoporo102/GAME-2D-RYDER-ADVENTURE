using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
//  Player đi vào vùng va chạm (trigger) của (StickyPlatform).
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //StickyPlatform obj va chạm có tên là "Player" hay không.
        if (collision.gameObject.name == "Player")
        {
            // "Player" -> children of StickyPlatform
            // "Player" will move along with StickyPlatform
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // "Player" is not a children of StickyPlatform
            collision.gameObject.transform.SetParent(null);
        }
    }

}
