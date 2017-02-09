using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class OrderInspector : MonoBehaviour
{
    public MenuList menuList;
    public OrderInfo orderInfo;   
    public Text[] textBox = new Text[3];  
    public string iQuandity, iPrice;        

    void Start()
    {
        menuList = gameObject.GetComponent<MenuList>();
        orderInfo = gameObject.GetComponent<OrderInfo>();
    }    

    public void SaveOrder(string ItemName)
    { 
        textBox[0].text = ItemName;
    }

    public void SaveOrder(int itemQuandity, double itemPrice)
    {
        Debug.Log(itemQuandity);
        
        textBox[1].text = itemQuandity.ToString(); 
        textBox[2].text = itemPrice.ToString();        
    }
}
