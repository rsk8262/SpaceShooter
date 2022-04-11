using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /*** VARIABLES ***/
    private BoundsCheck bndCheck; //reference to the boundary



    // Start is called before the first frame update
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();

    }

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            bndCheck.offUp = false; //reset bounds
        }

    }
}
