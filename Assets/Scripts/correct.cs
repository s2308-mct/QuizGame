using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//’Ç‰Á
using UnityEngine.SceneManagement;

public class Correct : MonoBehaviour
{
    public void change_button1()
    {
        if (csvReader.ans == 1)
            SceneManager.LoadScene("correct");
        else
            SceneManager.LoadScene("incorrect");
    }
    public void change_button2()
    {
        if (csvReader.ans == 2)
            SceneManager.LoadScene("correct");
        else
            SceneManager.LoadScene("incorrect");
    }
    public void change_button3()
    {
        if (csvReader.ans == 3)
            SceneManager.LoadScene("correct");
        else
            SceneManager.LoadScene("incorrect");
    }
    public void change_button4()
    {
        if (csvReader.ans == 4)
            SceneManager.LoadScene("correct");
        else
            SceneManager.LoadScene("incorrect");
    }
}
