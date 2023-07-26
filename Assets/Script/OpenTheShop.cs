using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheShop : MonoBehaviour
{
    [SerializeField]
    private bool IsOnTuch = false;
    [SerializeField]
    private GameObject Customers;
    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnTuch)
        {
            Customers.SetActive(true); 
        }
    }
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Playe")
        {
            IsOnTuch=true;
        }
    }
}
