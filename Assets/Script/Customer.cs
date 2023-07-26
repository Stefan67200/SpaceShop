using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Customer : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Transform[] Path;
    private int PathIndex = 0;
    [SerializeField]
    private Transform[] Path2;
    private int PathIndex2 = 0;
    [SerializeField]
    private bool isOnTuch=false;
    [SerializeField]
    private GameObject Sprite1;
    [SerializeField]
    private GameObject Sprite2;
    [SerializeField]
    private GameObject Customers;


    void Start()
    {
        if (!isOnTuch)
        {
          Sprite1.SetActive(true);
        }
        
        transform.position = Path[PathIndex].transform.position;
    }


    void Update()
    {

        FollowThePath();
        if (isOnTuch)
        {
            StartCoroutine(SwitchColor());

        }
       
        

    }
     void FollowThePath()
    {
        if (PathIndex <= Path.Length - 1)
        {

            transform.position = Vector2.MoveTowards(transform.position,
                Path[PathIndex].transform.position, speed * Time.deltaTime);
            if (transform.position == Path[PathIndex].transform.position)
            {
                PathIndex += 1;
            }

        }

    }
     void FollowSecoundPath()
    {
        if (PathIndex2 <= Path2.Length - 1)
        {

            transform.position = Vector2.MoveTowards(transform.position,
                Path2[PathIndex2].transform.position, speed * Time.deltaTime);
            if (transform.position == Path[PathIndex2].transform.position)
            {
                PathIndex2 += 1;
            }

        }
    }
  
    

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Activator")
        {
            isOnTuch = true;
        }
    }

    IEnumerator SwitchColor()
    {
        
        yield return new WaitForSeconds(5f);
        Sprite1.SetActive(false);
        Sprite2.SetActive(true);
        FollowSecoundPath();
        StartCoroutine(Disappear());




    }


    IEnumerator Disappear()
    {

        yield return new WaitForSeconds(6f);

        Destroy(gameObject,2);
        



    }

}
