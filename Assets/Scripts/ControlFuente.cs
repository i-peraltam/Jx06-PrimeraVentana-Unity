using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TMP_Text texto;

    public void AumentarFuente()
    {
        texto.fontSize += 4;
    }

    public void DisminuirFuente()
    {
        texto.fontSize -= 4;
    }
}