using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10;

    private void Awake() {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.inmpulsionar();
        }
    }

    private void inmpulsionar()
    {
        fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }
}
