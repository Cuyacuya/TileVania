using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length; //게임 세션의 갯수 => 3개
        if (numScenePersists > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); //DontDestroyOnLoad : 불러오는 중에 없애지 말 것
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
