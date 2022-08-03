using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public bool nv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nv == true)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            transform.Translate(Time.deltaTime * 3, 0, 0);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            transform.Translate(-Time.deltaTime * 3, 0, 0);
        }
    }
}
