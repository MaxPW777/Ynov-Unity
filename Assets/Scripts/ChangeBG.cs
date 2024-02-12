using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBG : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    private float elapsedTime;
    [SerializeField]
    private Toggle toggle;

    void Start()
    {
        cam = GetComponent<Camera>();
        toggle = toggle.GetComponent<Toggle>();
    }

    void Update()
    {
        elapsedTime++;
        if (toggle.isOn && elapsedTime > 1000){
            change_background();
        }
    }
    public void change_background()
    {
        cam.backgroundColor = Random.ColorHSV(0f, 1f, 1f, 1f);
    }

    public void toggle_background()
    {
        toggle.isOn = !toggle.isOn;
    }
}