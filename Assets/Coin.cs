using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }

    void Start()
    {
        GameObject manageObject = GameObject.Find("GameManager");
        gameManager = manageObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
