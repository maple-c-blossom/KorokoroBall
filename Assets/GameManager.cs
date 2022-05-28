using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int coinCount;
    public Text coinText;
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoinCount()
    {
        coinCount++;
        Debug.Log("CoinCount:" + coinCount);
        coinText.text = "CoinCount:" + coinCount;
    }
}
