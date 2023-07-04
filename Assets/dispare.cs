using UnityEngine;

public class dispare : MonoBehaviour
{
    public GameObject imagine;

    public void dispareImaginea()
    {
            imagine.SetActive(false);
    }
     public void apareImaginea()
    {
            imagine.SetActive(true);
    }
}

