using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton Init

    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public enum GameState { GAME = 0, END = 1 }
    public GameState state;

    public UnityEvent onWin;

    private Transform collectablesParent;

    private void Start()
    {
        AssignVariables();
    }

    public void CheckWin()
    {
        if (collectablesParent.childCount <= 1) //1 is because we are checking before destroying an object
        {
            onWin.Invoke();
            ChangeState(GameState.END);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ChangeState(GameState _state)
    {
        state = _state;
    }

    private void AssignVariables()
    {
        collectablesParent = GameObject.Find("Collectable").transform;
        state = GameState.GAME;
    }
}
