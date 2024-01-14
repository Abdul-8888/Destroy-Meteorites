using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    private const float destructionY = -30;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < destructionY)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 2.0f);
        Destroy(gameObject);
        GameManager.stoneDestroyed += 1;
    }
}
