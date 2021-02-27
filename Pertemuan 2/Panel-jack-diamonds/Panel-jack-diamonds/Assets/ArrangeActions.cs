using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ArrangeActions : MonoBehaviour
{
    private RectTransform panelRectTransform;
    // Start is called before the first frame update
    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
    }
    public void MoveDownOne()
    {
        print("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex =
        panelRectTransform.GetSiblingIndex();
        panelRectTransform.GetSiblingIndex(currentSiblingIndex - 1);
        print("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
    }
    public void MoveUpOne()
    {
        print("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
        int currentSiblingIndex =
        panelRectTransform.GetSiblingIndex();
        panelRectTransform.GetSiblingIndex(currentSiblingIndex + 1);
        print("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex());
    }
}
