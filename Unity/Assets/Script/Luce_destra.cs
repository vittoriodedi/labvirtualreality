using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luce_destra : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lucedx;
    private bool accesa = true;

    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && accesa)
        {
            lucedx.SetActive(false);
            accesa = false;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && !accesa)
        {
            lucedx.SetActive(true);
            accesa = true;
        }
    }
}