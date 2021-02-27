using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] keyPlaceholders; public Sprite key; public Sprite key_outline;
    public void OnChangeKeyTotal(int keyTotal)
    {
        for (int i = 0; i < keyPlaceholders.Length; ++i)
        {
            if (i < keyTotal)
                keyPlaceholders[i].sprite = key;
            else
                keyPlaceholders[i].sprite = key_outline;
        }
    }
}
