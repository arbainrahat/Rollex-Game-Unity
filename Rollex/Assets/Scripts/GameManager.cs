using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartdelay=1f;
    bool gameEnd = false;
    public GameObject levelCompleteUI;

    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnd==false)
        {
            gameEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartdelay);
        }

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
