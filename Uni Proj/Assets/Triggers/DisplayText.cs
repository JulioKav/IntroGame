using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public GameObject Uiobject;

    

    // Start is called before the first frame update
    void Start()
    {
        Uiobject.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            Uiobject.SetActive(true);
        }
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
