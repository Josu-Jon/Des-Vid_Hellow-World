using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPos : MonoBehaviour
{
    Transform MyTransform;
    bool goUp = true;
    // Start is called before the first frame update
    void Start()
    {
        MyTransform = this.transform;  
    }

    // Update is called once per frame
    void Update()
    {
        //POSICION
        /* Forma 1
         * Comprueba si tiene componente
         */
        Debug.Log("Posicion 1: " + this.GetComponent<Transform>().position);
        /* Forma 2
         * De esta manera no comprueba si tiene el componente
         */
        Debug.Log("Posicion 2: " + this.transform.position);
        /* Forma 3
         * Por lo general es la mejor, pero como todos los objetos
         * tienen posicion en este caso no es necesaria.
         */
        Debug.Log("Posicion 3: " + MyTransform.position);

        //ROTACION
    //    Debug.Log("Rotacion: " + this.GetComponent<Transform>().localRotation);

        //ESCALA
    //    Debug.Log("Rotacion: " + this.GetComponent<Transform>().localScale);

        //Movimiento por teclas
        ControlTeclado();
        Animacion();
    }

    private void ControlTeclado()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localScale += Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale += Vector3.down * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Plus))
        {
            transform.localScale += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            transform.localScale += Vector3.back * Time.deltaTime;
        }
    }
    private void Animacion()
    {
        MoveUp();
        MoveDown();

    }

    private void MoveDown()
    {
        while (goUp == false)
        {
            transform.position += Vector3.down * Time.deltaTime;
            if (transform.position.y <= 0)
            {
                goUp = true;
            }
        }
    }

    private void MoveUp()
    {
        while (goUp == true)
        {
            transform.position += Vector3.up * Time.deltaTime;
            if (transform.position.y >= 16)
            {
                goUp = false;
            }
        }
    }
}
