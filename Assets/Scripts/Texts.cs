using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public Text Destroyed;
    public Text Created;
    private string update;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        update = "Created Stones= " + GameManager.stoneCreated.ToString();
        Created.text = update;
        update = "Destroyed Stones= " + GameManager.stoneDestroyed.ToString();
        Destroyed.text = update;
    }
}
