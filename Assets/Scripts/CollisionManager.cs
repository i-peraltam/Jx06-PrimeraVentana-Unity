using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour
{
    private Image imagen;
    private Color colorOriginal;

    public Animator brillo1Animator;
    public Animator brillo2Animator;

    void Awake()
    {
        imagen = GetComponent<Image>();

        if (imagen != null)
        {
            colorOriginal = imagen.color;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fuego"))
        {
            if (imagen != null)
            {
                imagen.color = Color.red;
            }

            if (brillo1Animator != null)
            {
                brillo1Animator.SetBool("isActive", true);
            }

            if (brillo2Animator != null)
            {
                brillo2Animator.SetBool("isActive", true);
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

            if (brillo1Animator != null)
            {
                brillo1Animator.SetBool("isActive", false);
            }

            if (brillo2Animator != null)
            {
                brillo2Animator.SetBool("isActive", false);
            }

            Debug.Log("La Joya dejó de tocar el fuego");
        }
    }
}