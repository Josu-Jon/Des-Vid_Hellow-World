using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Object[] ChildList;
    int dropsWagons = 0;
    GameObject[] wagons;

    // Start is called before the first frame update
    void Start()
    {
        wagons = GameObject.FindGameObjectsWithTag("Vagon");
        dropsWagons = wagons.Length;
    }

    // Update is called once per frame
    void Update()
    {
            Movement();
            if (Input.GetKeyDown(KeyCode.Space))
            {
            wagons[dropsWagons-1].GetComponent<Transform>().parent = null;
                if(dropsWagons > 1)
                {
                    dropsWagons--;
                }
            }
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * 2;
        }
    }
}
