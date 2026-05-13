using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    CajaMovement movimientoCaja;

    // posiciones posibles
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;

    void Start()
    {
        movimientoCaja = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision col)
    {
        // toca player
        if (col.gameObject.CompareTag("Player"))
        {
            movimientoCaja.gameOver = true;

            UIManager.instance.gameOver = true;

            Destroy(col.gameObject);
        }

        // toca piso
        else if (col.gameObject.CompareTag("Piso"))
        {
            int randomPos = Random.Range(0, 3);

            if (randomPos == 0)
            {
                transform.position = pos1.position;
            }
            else if (randomPos == 1)
            {
                transform.position = pos2.position;
            }
            else
            {
                transform.position = pos3.position;
            }

            // resetear rotacion
            transform.rotation = Quaternion.identity;

            // aumentar velocidad
            movimientoCaja.AumentarVelocidad();
        }
    }
}