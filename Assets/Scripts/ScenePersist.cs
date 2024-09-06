using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length; //���� ������ ���� => 3��
        if (numScenePersists > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject); //DontDestroyOnLoad : �ҷ����� �߿� ������ �� ��
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
