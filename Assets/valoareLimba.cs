using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class valoareLimba : MonoBehaviour
{
   public sef valoareeLimba; 
   public int valoare;

   public void updateValue()
   {
      valoareeLimba.contor = valoare;
       SceneManager.LoadScene(1);
   }
}
