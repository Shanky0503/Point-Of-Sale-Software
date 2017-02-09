using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class OrderInfo : MonoBehaviour 
{
    string ItemName;
    int iNumber; 
    double ItemPrice;
    MenuList menuList;
    int iQuandity;
    OrderInspector orderInspector;
    double totalCost;
    public bool isReady = false;
    CreateText newText;
    //public int oNumber, LastoNumber;
   

    void Start()
    {
        menuList = gameObject.GetComponent<MenuList>();
        orderInspector = gameObject.GetComponent<OrderInspector>();
        newText = gameObject.GetComponent<CreateText>();
        iQuandity = 0;
    }

    public void OrderProcess(int num)
    {
       iNumber = num;
       iQuandity += 1;
       if (iQuandity <= 1)
       {
            Debug.Log("Entering Loop");
            for (int i = 0; i < 3; i++)
            {
                newText.CreatingObject();
                newText.CreatingText(newText.OrderTrans[i], newText.Orderpos[i], menuList.iNames[iNumber]);                
            }           
       }
       orderInspector.SaveOrder(menuList.iNames[iNumber]);
       totalCost = iQuandity * menuList.iPrice[iNumber]; 
       orderInspector.SaveOrder(iQuandity, totalCost);                           
       Debug.Log("1. " + menuList.iNames[iNumber]+"  Cost  " + "$ "+ menuList.iPrice[iNumber]+"  *  "+ iQuandity + "  = " + totalCost);
        //orderInspector.newTextbox();
        isReady = true;                                         
    }	

}
