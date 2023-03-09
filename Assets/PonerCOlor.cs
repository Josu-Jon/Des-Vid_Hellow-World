using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonerCOlor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hola, me llamo " + this.name);
        if (GetComponent<Material>())
        {
            Material material = GetComponent<Material>();
            material.color = Color.red;
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
