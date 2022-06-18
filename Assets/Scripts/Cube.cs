using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cube : MonoBehaviour
{
    public float velocidad;
    public Vector3 movimiento;
    public Vector3 escala;
    public Vector3 direccion;

    public int vida = 5;
    public TextMeshProUGUI vidaTexto;

    void Start()
    {
        transform.localScale += new Vector3(escala.x,escala.y,escala.z);
    }

    void Update()
    {
        vidaTexto.text = vida.ToString();
        Movimiento();
        Debug.Log(vida);
    }

    public void Movimiento(){
        //La velocidad y direccion de movimiento se controla por medio de el valor dado en el vector, siendo que un decimal en el eje X, por ejemplo: 0.1 moverá el cubo hacia la derecha a una velocidad muy lenta
        transform.Translate(movimiento.x,movimiento.y,movimiento.z * velocidad * Time.deltaTime);
    }

    public void Curar(){
        vida ++;
    }

    public void Daño(){
        vida--;
    }
}
