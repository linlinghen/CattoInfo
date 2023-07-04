using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptGrafuri : MonoBehaviour
{
private Renderer cubeRenderer;
public GameObject[] Cubes;
public sef cuburi;
private apare verde;
public int scena;
private dispare catto;

private void Start()
    {
        catto = GetComponent<dispare>();
        verde = GetComponent<apare>();
        
    }
private void OnMouseDown ()
{
      catto.dispareImaginea();
  if(gameObject == Cubes[cuburi.contor])
  {  verde.apareImaginea();
     cuburi.contor++;
     catto.dispareImaginea();
     if(gameObject == Cubes[7])
     { StartCoroutine(InvokeMenuDelayed(3f));
     }
  }
  else catto.apareImaginea();
  

  
}
private IEnumerator InvokeMenuDelayed(float delay)
{
    yield return new WaitForSeconds(delay);
    SceneManager.LoadScene(scena);
}

}