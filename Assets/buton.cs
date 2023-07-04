using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
    public Image[] pages; 
    private int i=0;
    public Image fundal;
    public int nrnr;
    void Start()
    {
        
        ShowPage(i);
    }

    public void NextPage()
    {
        
        i++;
        if (i < pages.Length)
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

