using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image lockImage; public Sprite iconLock; public Sprite iconNoLock;
    private bool carryingLock = false; void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Lock"))
        {
            carryingLock = true; UpdateLockImage(); 
        }
    }
    private void UpdateLockImage()
    {
        if (carryingLock) lockImage.sprite = iconLock;
        else
            lockImage.sprite = iconNoLock;
    }
}
