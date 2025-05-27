using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luce : MonoBehaviour
{
    public GameObject light;
    private bool accesa = true;

    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && accesa){
            light.SetActive(false);
            accesa = false;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && !accesa){
            light.SetActive(true);
            accesa = true;
        }

    }
}


