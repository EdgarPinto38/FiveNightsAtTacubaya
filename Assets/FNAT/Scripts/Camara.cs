using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speed;
    public float angle;
    Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        angle = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Round(transform.eulerAngles.y) != angle)
        {
            transform.Rotate(direccion * speed * Time.deltaTime);
        }

    }

    //Rotacion Derecha
    public void RotDer()
    {
        angle = 120;
        direccion = Vector3.up;
    }

    //Rotacion Izquierda
    public void RotIzq()
    {
        angle = 60;
        direccion = -Vector3.up;
    }

    //Mouse Fuera
    public void MouseFuera()
    {
        direccion = Vector3.zero;
    }
}
