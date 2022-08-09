using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killmonster : MonoBehaviour
{
    public GameObject replay;
    public AudioSource Dead;
    public AudioSource Coin;
    public static int diemTong = 0;
    public GameObject diemText;
    // Start is called before the first frame update
    void Start()
    {
        CongDiem(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CongDiem(int diemCong)
    {
        diemTong += diemCong;
        diemText.GetComponent<Text>().text = "Point: " + diemTong.ToString();
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
            replay.SetActive(true);
        }
        if (collision.gameObject.tag == "tren")
        {
            Destroy(GameObject.Find(name_monster));
        }

        if (collision.gameObject.tag == "xu")
        {
            CongDiem(1);
            Coin.Play();
            Destroy(GameObject.Find(name_coin));
        }
    }
}
