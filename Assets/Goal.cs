using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextLevelBotton;
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã");

        clearText.SetActive(true);
        nextLevelBotton.SetActive(true);
        playSound.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
