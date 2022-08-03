using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killmonster : MonoBehaviour
{
    public AudioSource Dead;
    public AudioSource Coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name_coin = collision.attachedRigidbody.gameObject.name;
        string name_monster = collision.attachedRigidbody.gameObject.name;
        if (collision.gameObject.tag == "trai")
        {
            Dead.Play();
            Destroy(GameObject.Find("nv"));
            Time.timeScale = 0;
        }
        if (collision.gameObject.tag == "tren")
        {
            Destroy(GameObject.Find(name_monster));
        }

        if (collision.gameObject.tag == "xu")
        {
            Coin.Play();
            Destroy(GameObject.Find(name_coin));
        }
    }
}
