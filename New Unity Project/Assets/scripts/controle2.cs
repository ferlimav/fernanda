using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle2 : MonoBehaviour
{
    public Vector3 direção;
    public float velocidade;
    Rigidbody Rb;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        direção = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(direção * velocidade * Time.deltaTime);
    }
}
