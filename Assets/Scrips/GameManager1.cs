using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager1 : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null) instance = this;
        Time.timeScale = 1f;
        
    }

    public void GameOver()
    { 
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
