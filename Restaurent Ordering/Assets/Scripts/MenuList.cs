using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuList : MonoBehaviour
{
    public List<string> iNames = new List<string>();
    public List<double> iPrice = new List<double>();

    void Start()
    {      

        iNames.Add("Beef Satay");
        iNames.Add("Chicken Satay");
        iNames.Add("Mixed Satay");
        iNames.Add("Curry Puff");
        iNames.Add("Rojak Mamak");
        iNames.Add("Deep Fried Calamari");
        iNames.Add("Spring Rolls");
        iNames.Add("Tamarind Tiger Prawn");
        iNames.Add("Chicken Salad");
        iNames.Add("Tom Yum Ayum");
        iNames.Add("Mixed Platter");
        iPrice.Add(11.90);
        iPrice.Add(11.90);
        iPrice.Add(11.90);
        iPrice.Add(9.00);
        iPrice.Add(12.90);
        iPrice.Add(12.90);
        iPrice.Add(7.50);
        iPrice.Add(16.90);
        iPrice.Add(10.90);
        iPrice.Add(11.90);
        iPrice.Add(30.00);
    }

}



