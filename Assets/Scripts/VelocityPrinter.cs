using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class VelocityPrinter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text VELOCITEXT;

    [SerializeField]
    private GameObject PERSO;
    private Rigidbody2D rb;
    void Start()
    {

        rb = PERSO.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        VELOCITEXT.text = rb.velocity.y.ToString() + "M/S";
    }
}
