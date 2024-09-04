using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;

    void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length; //게임 세션의 갯수 => 3개
        if(numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); //DontDestroyOnLoad : 불러오는 중에 없애지 말 것
        }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    void TakeLife()
    {
        playerLives--;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex);
    }

    private void ResetGameSession()
        {
            SceneManager.LoadScene(0);
            Destroy(gameObject);
        }
}
