using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class menuthree : MonoBehaviour
{
    public void scanm()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void companypage()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void feed()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }





}
