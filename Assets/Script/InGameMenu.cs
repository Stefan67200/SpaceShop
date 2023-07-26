using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InGameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      if(Input.GetKeyDown(KeyCode.P) && !isOpen)
        {
           
            menu.SetActive(true);
            isOpen = true;

            
            
        }
       if (Input.GetKeyDown(KeyCode.O)&&  isOpen)
        {
            menu.SetActive(false);
            isOpen = false;
        }

    }
}
