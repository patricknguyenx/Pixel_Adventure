using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetTrap : MonoBehaviour
{
    public GameObject trap1;
    public GameObject trap2;
    GameObject newtrap; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spamTrap()
    {
        if (newtrap != null)
        {
            Destroy(newtrap.gameObject);
        }

        newtrap = Instantiate(trap1);
        newtrap.transform.position = trap2.transform.position;


    }
}
