using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class BinarySearchScriptMain : MonoBehaviour
{   public GameObject[] Imagini;
    public GameObject[] cubes; // vector de cuburi in joc
    private int[] cubApasat = { 3, 5, 4 }; //cubul care trebuie sa fie apasat in functie de Cuburi.contor
    private int[] cuburiColorate = { 0, 6, 4 }; //un reper pentru intervalul de cuburi a caror culoare trebuie schimbata in functie de Cuburi.contor
    public sef Cuburi; //contor comun
    public dispare[] cattoFeedback; //feedback
    private apare DisplayImageCube; //imaginea de de-asupra cubului
    public sef ValoareLimba;

    private void Start()
    {
       DisplayImageCube = GetComponent<apare>();
    }

    private void OnMouseDown()
    {
        cattoFeedback[ValoareLimba.contor].dispareImaginea(); //dispare feedbackul inainte de noua alegere
        if (gameObject == cubes[cubApasat[Cuburi.contor]])// daca cubul selectat este cel corect
        {
            if (gameObject == cubes[4]) //daca a ajuns la finalul nivelului
            {   Imagini[4].SetActive(true);
                Renderer cubeRenderer = cubes[4].GetComponent<Renderer>();
                cubeRenderer.material.color = Color.green; //se schimba culoarea
                DisplayImageCube.apareImaginea(); //apare tortul

                StartCoroutine(LoadAfterDelay()); //se incarca meniul
            }
            else
            {
                DisplayImageCube.apareImaginea(); //apare imaginea cu mancarea
                int a = cubApasat[Cuburi.contor];
                int b = cuburiColorate[Cuburi.contor];
                // a si b reprezinta capetele intervalului de cuburi care trebuie colorat
                if (a > b) //sunt interschimbate daca a este mai mare ca b
                {
                    int auxiliar = a;
                    a = b;
                    b = auxiliar;
                }

                for (int j = a; j <= b; j++) //sunt colorate toate cuburile din interval
                {
                    Imagini[j].SetActive(true);
                    ChangeColor(cubes[j]);
                }

                Cuburi.contor++; //se mareste contorul
            }
        }
        else cattoFeedback[ValoareLimba.contor].apareImaginea(); //apare feedbackul la alegerea gresita

    }

    private void ChangeColor(GameObject cube) //funtia pentru schimbarea culorii
    {
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.color = Color.green;
    }
    
    private IEnumerator LoadAfterDelay() //funtia pentru schimbarea scenei
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
    }
    
}
