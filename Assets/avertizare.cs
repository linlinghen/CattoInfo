using UnityEngine;
using UnityEngine.UI;

public class avertizare : MonoBehaviour
{
    public Image Catto;

    private void OnMouseDown()
    {
        Catto.gameObject.SetActive(true);
    }
}
