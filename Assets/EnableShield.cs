using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableShield : MonoBehaviour
{
    public GameObject Shield;
    // Start is called before the first frame update


    public void SetActive(bool enable)
    {
        Shield.SetActive(enable);
         
    }

    public bool isActive() {
        return Shield.activeInHierarchy;
    }
}
