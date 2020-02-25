using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    private Diretor diretor;
    private Vector3 posicaoInicial;

    private void Awake() {
        this.posicaoInicial = this.transform.position;
        this.fisica = GetComponent<Rigidbody2D>();
        this.diretor = GameObject.FindObjectOfType<Diretor>();
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
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        this.fisica.simulated = false;
        this.diretor.finalizarJogo();
    }

    public void reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
