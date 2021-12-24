using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
   public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;

    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {
        score += 10;
        OnScoreChanged?.Invoke(score);
    }

    public void StartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(StartGameAsync());
    }

    private IEnumerator StartGameAsync()
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnMenu()
    {
        StartCoroutine(ReturnMenuAsync());
    }

    public IEnumerator ReturnMenuAsync()
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("Menu");
    }
}
