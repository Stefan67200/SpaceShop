using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorO : MonoBehaviour
{
    [SerializeField]
    private bool isOnTuch= false;
    [SerializeField]
    private Animator DoorAnim;
    [SerializeField]
    private AudioSource DoorSound;
    [SerializeField]
    private AudioClip Audio;
   


    // Start is called before the first frame update
    void Start()
    {
        DoorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnTuch)
        {
            DoorAnim.SetTrigger("DoorOP");
            DoorSound.PlayOneShot(Audio,1);
            isOnTuch = false;
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag == "Customer")
        {
            isOnTuch = true;
        }
    }




}
