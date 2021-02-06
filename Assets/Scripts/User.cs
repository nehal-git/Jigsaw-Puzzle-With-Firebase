using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public string userEmail;
    public string userScore;

    public User()
    {
        userEmail = Score.uEmail;
        userScore = Score.uScore;
    }
}