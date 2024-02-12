using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    private bool checkbox = false;

    private float elapsedTime;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    public void changeColor()
    {
        cam.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f);
    }

    public void toggleCycleColor()
    {
        checkbox = !checkbox;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (checkbox && elapsedTime >= 2)
        {
            changeColor();
            elapsedTime = 0f;
        }
    }

}