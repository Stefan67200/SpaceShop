using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    [SerializeField]
    private Transform Handslot;
    [SerializeField]
    private bool IsOnTuch = false;
    [SerializeField]
    private GameObject Box;
    [SerializeField]
    private bool IsOnPickUp=false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && IsOnTuch)
        {

            IsOnPickUp = true;

            Box.transform.position = Handslot.transform.position;
            Box.transform.SetParent(Handslot.transform);
            IsOnTuch = false;



        }
        if (Input.GetKeyDown(KeyCode.T) && IsOnPickUp)
        {
           
            IsOnTuch = false;
            Box.transform.SetParent(null);
            IsOnPickUp = false;

        }




    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag== "Player")
        {
            IsOnTuch=true;
        }

    }


}
