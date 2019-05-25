using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_script : MonoBehaviour
{
    public int HP;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    
    

    private void damage ()
    {

        if (HP >0 && Input.GetMouseButtonDown(0))
        {
            HP--;
            Debug.Log("Ouch!");
        }
    }

}
