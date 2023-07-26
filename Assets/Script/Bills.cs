using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bills : MonoBehaviour
{
    [SerializeField]
    private GameObject UIbill;
    [SerializeField]
    private bool isOnTuch = false;
    [SerializeField]
    private AudioSource audio;
    
   






    void Start()
    {
        UIbill.SetActive(false);
        audio = GetComponent<AudioSource>();
            
    }

    
    void Update()
    {
       if(isOnTuch)
        {

            UIbill.SetActive(true);
            
            if (Input.GetMouseButtonDown(0))
            {
                isOnTuch=false;
                UIbill.SetActive(false);
                audio.Play();

            }
        }


        
    }
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Customer")
        {
            isOnTuch = true;

        }
    }
    
}
