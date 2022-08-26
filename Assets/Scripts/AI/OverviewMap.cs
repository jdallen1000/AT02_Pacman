using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverviewMap : MonoBehaviour
{
    public GameObject UImap;


    // Start is called before the first frame update
    void Start()
    {
        UImap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //Get current State
            bool currentState = UImap.activeSelf;

            //Flip it
            currentState = !currentState;

            //Set the current State to the flipped value
            UImap.SetActive(currentState);
        }
    }

    



        
}
