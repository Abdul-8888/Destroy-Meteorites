using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwakeInterface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.stoneCreated = 0;
        GameManager.stoneDestroyed = 0;
    }

    public void Click()
    {
        SceneManager.LoadScene("Stage1");
    }
}
