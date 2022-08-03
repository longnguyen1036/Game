using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEngine.UI;


public class login : MonoBehaviour
{
    public InputField txtUSN;
    public InputField txtPW;

    public class APIURL
    {
        public static string LOGIN_URL = "https://sale.daiduongcorp.vn/servergameapi/views/checklogin.php";
        public static string REGISTER_URL = "http://localhost:9999/views/register.php";
        public static string GETTOPSCORE_URL = "http://localhost:9999/views/getTop5HightScoreUsers.php";
    }
    private IEnumerator CreateRequest()
    {
        string user_name = txtUSN.GetComponent<InputField>().text;
        string password = txtPW.GetComponent<InputField>().text;
        if (string.Equals(user_name.Trim(), "") || string.Equals(password.Trim(), ""))
        {
           
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("user_name", user_name);
            form.AddField("password", password);
            UnityWebRequest request = UnityWebRequest.Post(APIURL.LOGIN_URL, form);
            yield return request.SendWebRequest();

            if (request.responseCode == 200)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                Debug.Log("tai khoan hoac mat khau sai");
            }
        }
    }
    public void CheckLogin()
    {
        StartCoroutine(CreateRequest());
    }
}
