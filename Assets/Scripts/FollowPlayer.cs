using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Gari;
    private Vector3 offset= new Vector3 (0,3.81f,-8.07f);
    void Start()
    {
     
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        transform.position=Gari.transform.position+offset;
    }

}

