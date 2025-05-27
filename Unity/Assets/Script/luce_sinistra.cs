using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luce_sinistra : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lucesx;
    private bool accesa = true;

    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && accesa)
        {
            lucesx.SetActive(false);
            accesa = false;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.G) && !accesa)
        {
            lucesx.SetActive(true);
            accesa = true;
        }
    }
}