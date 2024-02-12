using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject capsuleObject;
    private Vector2 startLocation;
    
    public void Start(){
        startLocation = capsuleObject.transform.position;
    }
    public void tp_to_start()
    {
        capsuleObject.transform.position = startLocation;
    }
}
