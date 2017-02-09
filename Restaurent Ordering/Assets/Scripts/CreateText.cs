using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateText : MonoBehaviour
{
    public Vector2[] Orderpos = new Vector2[3];
    public Transform[] OrderTrans = new Transform[3];
    public GameObject newInstaObject;

    void Start()
    {
        Orderpos[0] = new Vector2 (140f, -15f);
        Orderpos[1] = new Vector2 (0f, -15f);
        Orderpos[2] = new Vector2 (0f, -15f);          
    }

    public GameObject CreatingText(Transform ObjectTransform, Vector2 pos, string TextName)
    {
        GameObject UItextGO = new GameObject(TextName);
        UItextGO.transform.SetParent(ObjectTransform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.anchoredPosition = pos;

        Text text = UItextGO.AddComponent<Text>();
        text.text = TextName;
        text.name = TextName;

        return UItextGO;
    }

    public void CreatingObject()
    {
        Instantiate(newInstaObject);
        transform.SetParent(OrderTrans[0], false);
    }
}
