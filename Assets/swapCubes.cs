using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class swapCubes : MonoBehaviour
{
    public GameObject[] cubes; //Cuburile din joc
    private int[] order = {2, 3, 1, 4}, replace = {0, 1, 0, 0};
    //order - cubul care trebuie selectat (in functie de contor (ContorComun.contor))
    //replace - cubul cu care trebuie inlocuit (in functie de contor (ContorComun.contor))
    public sef ContorComun;
    private Renderer cubeRenderer; //utilizat pentru schimbarea culorii
    public dispare[] cattoFeedback; //Feedback la alegerea gresita ++
    private apare AlegereCorecta;
    public GameObject imagine;
    public GameObject imagine2;
    public GameObject imagine3;
    public sef ValoareLimba; //

    private void Start()
    {
        //cattoFeedback = GetComponent<dispare>();
        AlegereCorecta = GetComponent<apare>();
    }

    private void SwapCubes(GameObject cube1, GameObject cube2) //functie pentru schimbarea pozitiei cuburilor
    {
        Vector3 cube1OriginalPosition = cube1.transform.position;
        Vector3 cube2OriginalPosition = cube2.transform.position;

        cube1.transform.position = cube2OriginalPosition;
        cube2.transform.position = cube1OriginalPosition;
    }

    private void ChangeColor ( GameObject cube1)
    {
        cubeRenderer = cube1.GetComponent<Renderer>();
        cubeRenderer.material.color = Color.green;
    }

    private void OnMouseDown()
    {
        cattoFeedback[ValoareLimba.contor].dispareImaginea(); //dispare Feedbackul
        if (ContorComun.contor < cubes.Length-1 && cubes[order[ContorComun.contor]] == gameObject) //daca cubul ales e corect
        {
            SwapCubes(cubes[order[ContorComun.contor]], cubes[replace[ContorComun.contor]]); //se schimba cuburile
            ChangeColor (cubes[order[ContorComun.contor]]); // se schimba culoarea
            AlegereCorecta.apareImaginea();
            imagine2.SetActive(false);
            if (ContorComun.contor == 3) //daca a ajuns la finalul nivelului
            {
            imagine.SetActive(true);
            imagine3.SetActive(false);
            ChangeColor (cubes[0]);
            StartCoroutine(LoadMenuAfterDelay()); //se schimba scena
            }
            ContorComun.contor++;
        }
        else cattoFeedback[ValoareLimba.contor].apareImaginea(); //Feedback la alegerea gresita
    }

     private IEnumerator LoadMenuAfterDelay() //functie pentru schimbarea scenei
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
    }
}
