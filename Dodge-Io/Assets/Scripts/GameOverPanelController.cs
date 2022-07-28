using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverPanelController : MonoBehaviour
{
    [SerializeField] HitAction gameOverControllerScript;
    [SerializeField] GameObject GameOverPanel;
    
    void Update()
    {
        if (gameOverControllerScript.GameOverStatus)
        {
            GameOverPanel.SetActive(true);
        }
    }

    public void OnReplayButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
