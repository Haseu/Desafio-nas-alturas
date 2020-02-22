using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaculo;
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;

    private void Awake() {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.obstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        } 
    }
}
