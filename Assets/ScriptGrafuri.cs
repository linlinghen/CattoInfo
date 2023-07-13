using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptGrafuri : MonoBehaviour
{

public GameObject[] Cubes;
public sef cuburi;
private apare verde;
public int scena;
public dispare[] catto;
public sef ValoareLimba;
public GameObject Imagine;

private void Start()
    {
        verde = GetComponent<apare>();
    }
private void OnMouseDown ()
{
      catto[ValoareLimba.contor].dispareImaginea();
  if(gameObject == Cubes[cuburi.contor])
  {  
     verde.apareImaginea();
      Imagine.SetActive(false);
     cuburi.contor++;
      
     catto[ValoareLimba.contor].dispareImaginea();

     if(Cubes.Length==8)
     { 
     StartCoroutine(InvokeMenuDelayed(3f));
     }
  }
  else catto[ValoareLimba.contor].apareImaginea();
  

  
}
private IEnumerator InvokeMenuDelayed(float delay)
{
    yield return new WaitForSeconds(delay);
    SceneManager.LoadScene(scena);
}

      

}