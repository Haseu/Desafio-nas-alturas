using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    Rigidbody2D fisica;

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
        fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
