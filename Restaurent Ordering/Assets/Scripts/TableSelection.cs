using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TableSelection : MonoBehaviour
{    
    public GameObject Bobject;
    public Button TableButton;
    public string ButtonText;
    public int TableNumber;
    private bool NumberSelected = false;

    void Start()
    {
        Bobject = this.gameObject;
    }

    public void OnClick()
    {
        TableButton = this.GetComponent<Button>();
        ButtonText = this.GetComponentInChildren<Text>().text;
        TableNumber = int.Parse(ButtonText);
        NumberSelected = true;
        TableBooked(NumberSelected);
    }

    void TableBooked(bool Tselected)
    {
        if (NumberSelected)
        {
            Debug.Log("Table Number"+TableNumber);
            SceneManager.LoadScene("Main Screen");
        }
    }

    
}

