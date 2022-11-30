using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Vertical_Input;
    private float Horizontal_Input; 
    private float speed=15.0f;
    private float turnSpeed=25.0f;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputId;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //Taking keyboard inputs via Input Manager
      Horizontal_Input=Input.GetAxis("Horizontal"+inputId);
      Vertical_Input=Input.GetAxis("Vertical"+inputId);
        //For driving vechile forward or Backward
      transform.Translate(Vector3.forward*Time.deltaTime*speed*Vertical_Input);
        //For turning vechile left or right
      transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*Horizontal_Input);
      
      if (Input.GetKeyDown(switchKey)){
        mainCamera.enabled = !mainCamera.enabled;
        hoodCamera.enabled = !hoodCamera.enabled;
      }
    }
}
