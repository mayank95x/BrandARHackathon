using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menufeed : MonoBehaviour
{
    public void livemap()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void scan()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void companypage()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

}
