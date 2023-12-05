using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float rocketSpeed = 5f;
    public float destroyAfterSeconds = 5f;
    private float timer = 0f;

    private Rigidbody rb;

    // M�todo para configurar el movimiento inicial del cohete con una direcci�n espec�fica
    public void SetInitialMovement(Vector3 direction)
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = direction.normalized * rocketSpeed;
            rb.useGravity = false; // Desactivar la gravedad
        }
    }

    void Update()
    {
        // Destruir el cohete despu�s de un tiempo determinado
        timer += Time.deltaTime;
        if (timer >= destroyAfterSeconds)
        {
            Destroy(gameObject);
        }
    }

    // L�gica de autodestrucci�n al alcanzar un l�mite (en este ejemplo, se autodestruye al llegar a Y = 10)
    private void FixedUpdate()
    {
        if (transform.position.y >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
