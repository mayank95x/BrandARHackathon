using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuone : MonoBehaviour
{
     public void startapp()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
