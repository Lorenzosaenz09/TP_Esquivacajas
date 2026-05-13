using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 5f;
    public float aumentoVelocidad = 1f;

    public bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    public void AumentarVelocidad()
    {
        speed += aumentoVelocidad;
    }
}