using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public GameObject capsuleObject;
    // Start is called before the first frame update
    public void tp_to_middle()
    {
        capsuleObject.transform.position = new Vector2(0,0);
    }
}
