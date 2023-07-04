using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class changescene : MonoBehaviour
{ public int nrsc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void schimba ()
    {
         SceneManager.LoadScene(nrsc);
    }
}
