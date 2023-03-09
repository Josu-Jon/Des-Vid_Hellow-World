using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buscador : MonoBehaviour
{
    Object[] listaObjetos;
    Object ObjetoEsp;
    Object[] ObjetosCubo;
    Object ObjetoCaps;
    [Serialize]
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        listaObjetos = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
        ObjetoEsp = GameObject.Find("Capsule");
        ObjetosCubo = GameObject.FindGameObjectsWithTag("Cubo");
    }
    // Update is called once per frame
    void Update()
     {
        /*     foreach (var objeto in listaObjetos)
             {
                 if (objeto.GetComponent<MeshRenderer>())
                     objeto.GetComponent<MeshRenderer>().material.color = color;
             }
        */
        ObjetoEsp.GetComponent<MeshRenderer>().material.color = Color.red;
        foreach (var objeto in ObjetosCubo)
        {
            if (objeto.GetComponent<MeshRenderer>())
                objeto.GetComponent<MeshRenderer>().material.color = color;
        }
    }
    
        
    
}
