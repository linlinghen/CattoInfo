using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchimbaImagineButon : MonoBehaviour
{
    public Button buton; 
    public Sprite imagine;
    public sef ValoareLimba;

    void Start()
    {
        if(ValoareLimba.contor == 1)
            schimbaImagine();
    }

    public void schimbaImagine()
    {
        Image imagineActuala = buton.GetComponent<Image>();
        imagineActuala.sprite = imagine;
    }
}
