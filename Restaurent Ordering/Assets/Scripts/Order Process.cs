using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OrderProcess : MonoBehaviour
{
    int orderNumber;
    Text str;
    public OrderInfo oInfo;

    void Start()
    {
        oInfo = gameObject.GetComponent<OrderInfo>();
    }   

    void Update()
    {
        if (oInfo.isReady)
        {
            str = gameObject.AddComponent<Text>();
            str.text = "Hello World";
        }
                
    }
}
