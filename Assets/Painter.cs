using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public Object[] objectsList;
    [Serialize]
    public Color color;
    [Serialize]
    public string paintTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectsList = GameObject.FindGameObjectsWithTag(paintTag);
        foreach (var item in objectsList)
        {
            if(item.GetComponent<MeshRenderer>())
            {
                item.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
