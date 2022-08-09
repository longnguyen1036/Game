using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;
public class register : MonoBehaviour
{
    public InputField txtUSN;
    public InputField txtPW;
    public static string REGISTER_URL = "https://fpoly-hcm.herokuapp.com/api/users/register";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator CreateRequest()
    {
        string email = txtUSN.GetComponent<InputField>().text;
        string password = txtPW.GetComponent<InputField>().text;
        if (string.Equals(email.Trim(), "") || string.Equals(password.Trim(), ""))
        {
            Debug.Log("tai khoan hoac mat khau sai");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("email", email);
            form.AddField("password", password);
            UnityWebRequest request = UnityWebRequest.Post(REGISTER_URL, form);
            yield return request.SendWebRequest();
            Debug.Log(request.responseCode);
            if (request.responseCode == 200)
            {

                SceneManager.LoadScene("LoginScene");
            }
            else
            {
                Debug.Log("dang ký thất bại");
            }
        }
    }
    public void Register()
    {
        StartCoroutine(CreateRequest());
    }

}