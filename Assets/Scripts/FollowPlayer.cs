using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al GameObject de la nave

    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    public Vector3 offset; // Offset para ajustar la posici�n de la c�mara

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Si deseas que la c�mara siempre mire hacia la nave (opcional):
        // transform.LookAt(player);
    }
}