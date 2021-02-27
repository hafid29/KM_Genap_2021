using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text keyText; private int totalKey = 0; void Start()
    {
        UpdateKeyText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Key"))
        {
            totalKey++; UpdateKeyText(); Destroy(hit.gameObject);
        }
    }
    private void UpdateKeyText()
    {
        string keyMessage = "Keys  =  " + totalKey; keyText.text = keyMessage;
    }
}
