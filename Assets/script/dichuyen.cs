using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dichuyen : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    public bool isRight = true;
    public bool isPause = false;
    public AudioSource Pause;
    public AudioSource Jump;
    public AudioSource Dead;
    public bool nhay = true;
    public GameObject SrcPause;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(big_item.posx, big_item.posx, big_item.posx);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = false;
            ani.SetBool("isRunning", true);
            ani.Play("Running");
            transform.Translate(-Time.deltaTime * 3, 0, 0);
            transform.localScale = new Vector3(-big_item.posx, big_item.posx, big_item.posx);
        }
 
        if (Input.GetKey(KeyCode.Space)/* && nhay*/)
        {
            if (isRight == true)
            {
                Jump.Play();
                transform.Translate(0, Time.deltaTime * 10f, 0);
            }
            else
            {
                transform.Translate(0, Time.deltaTime * 10f, 0);
            }
            //nhay = false;

        }
        if (Input.GetKey(KeyCode.P))
        {
            isPause = !isPause;
            if (isPause)
            {
                SrcPause.SetActive(true);
                Pause.Play();
                Time.timeScale = 0;
            }
            else
            {
                SrcPause.SetActive(false);
                Pause.Play();
                Time.timeScale = 1;
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nendat")
        {
            nhay = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "roixuong")
        {
            Dead.Play();
            Time.timeScale = 0;
        }
    }
}
