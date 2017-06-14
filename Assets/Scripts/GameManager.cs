using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private static GameManager instance = null;
    private GameState currentState = GameState.PLAY;

    public static GameManager Instance {get{return instance;} set{instance = value;}}
    public GameState CurrentState {get{return currentState;} set{currentState = value;}}

    private void Awake() {
        Init();
    }

    private void Init() {
        if (Instance != null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }
}
