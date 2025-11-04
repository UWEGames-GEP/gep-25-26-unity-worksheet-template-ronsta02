using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Android;

public enum GameState
{
    GAMEPLAY,
    PAUSE
}

public class GameManager : MonoBehaviour
{
    public GameState State;
    public bool ChangedState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        State = GameState.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {


        if (State == GameState.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                State = GameState.PAUSE;
                ChangedState = true;
            }
        }
        else if (State == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                State = GameState.GAMEPLAY;
                ChangedState = true;
            }
        }
    }

    private void LateUpdate()
    {
        if (ChangedState)
        {

            ChangedState = false;

            if (State == GameState.GAMEPLAY)
            {
                Time.timeScale = 1f;
            }
            else if (State == GameState.PAUSE)
            {
                Time.timeScale = 0f;
            }
            
        }

    }
  
}
