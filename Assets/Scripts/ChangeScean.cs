using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScean : MonoBehaviour
{
    public void change_button()
    {
        SceneManager.LoadScene("quiz");
    }
}
