using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour
{
    private Image imagen;
    private Color colorOriginal = Color.white;

    private void Awake()
    {
        imagen = GetComponent<Image>();

        if (imagen != null)
        {
            colorOriginal = imagen.color;
        }
        else
        {
            Debug.LogError("CollisionManager: Joya no tiene componente Image.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colisión detectada con: " + other.gameObject.name);

        if (other.CompareTag("Fuego"))
        {
            if (imagen != null)
            {
                imagen.color = Color.red;
            }

            Debug.Log("La Joya entró en contacto con el fuego");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Fuego"))
        {
            if (imagen != null)
            {
                imagen.color = colorOriginal;
            }

            Debug.Log("La Joya dejó de tocar el fuego");
        }
    }
}