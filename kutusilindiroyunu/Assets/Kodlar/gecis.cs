using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.name == "Silindir")
        {
            Application.LoadLevel("Sahne2");

        }
    }
}
