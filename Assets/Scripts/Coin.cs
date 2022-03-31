using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int count=0;
    [SerializeField] private AudioClip clickSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            count++;
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position);
            Destroy(other.gameObject);
        }
    }

}
