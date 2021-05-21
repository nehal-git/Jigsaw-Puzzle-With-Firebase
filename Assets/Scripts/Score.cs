using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public InputField UserEmail;

    public static string uScore;
    public static string uEmail;

    public void SubmitDatabase()
    {
        uEmail = UserEmail.text;
        uScore = score.text;

        PostToDatabase();

       
    }

    private void PostToDatabase()
    {

        User user = new User();
        RestClient.Put("your_firebase_db_url" + uEmail + ".json", user);


    }


}
