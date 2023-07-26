using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_M : MonoBehaviour
{
    [SerializeField]
    private float Speed = 5f;
    private Vector3 Player;
    [SerializeField]
    


    void Start()
    {
       Player= transform.position;
    }

    
    void Update()
    {

       
        if (Input.GetMouseButtonDown(1))
        {
            Player = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Player.z = transform.position.z; 
        }
        transform.position = Vector3.MoveTowards(transform.position, Player, Speed * Time.deltaTime);
    }
   
}
