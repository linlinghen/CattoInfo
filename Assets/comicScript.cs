using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comicScript : MonoBehaviour
{
    public Image[] pages; // imaginile pentru comic
    public sef valoareLimba; //0 pentru romana, 1 pentru engleza 
    private int i;  
    public Image fundal;
    public int nrnr;// numarul scenei care trebuie afisata dupa terminarea comicului
    private int lungime; //lungimea comicului

    void Start()
    {
        i = valoareLimba.contor * (pages.Length/2); // valoarea initiala a lui i in functie de limba aleasa
        lungime = pages.Length/2 + i; // sfarsitul comicului in functie de limba aleasa
        ShowPage(i); // se afiseaza prima imagine 
    }

    public void NextPage()
    {
        
        i++; 
        if (i < lungime )  
        {
            ShowPage(i);
        }
        else  
        {
            SceneManager.LoadScene(nrnr);
        }
    }

    private void ShowPage(int j) 
    {
        
        fundal.sprite = pages[j].sprite;

    }
}

