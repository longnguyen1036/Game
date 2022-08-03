using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_item : MonoBehaviour
{
    public static float posx = 1.5f;
    public GameObject item_big;
    public AudioSource Levelup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "big_item") {
            Levelup.Play();
            posx = 2f;
            Destroy(item_big);
        }
    }
}
