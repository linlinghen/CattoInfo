using UnityEngine;
using UnityEngine.UI;

public class avertizare : MonoBehaviour
{
    public Image[] Catto;
    public sef ValoareLimba;

    private void OnMouseDown()
    {
        Catto[ValoareLimba.contor].gameObject.SetActive(true);
    }
}
