using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndInterface : MonoBehaviour
{
    public Text Created;
    public Text Destroyed;

    // Start is called before the first frame update
    void Start()
    {
        Created.text = "Created = " + GameManager.stoneCreated;
        Destroyed.text = "Destroyed = " + GameManager.stoneDestroyed;
    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
}
