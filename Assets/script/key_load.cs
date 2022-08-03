using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key_load : MonoBehaviour
{
    public GameObject key_map;
    bool key = false;
    public AudioSource keysound;
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
        if (collision.gameObject.tag == "key_load") {
            key = true;
            Destroy(key_map);
            keysound.Play();
        }
        if (key && collision.gameObject.tag =="last_map")
        {
            SceneManager.LoadScene("BeginScene");
        }
    }
}
