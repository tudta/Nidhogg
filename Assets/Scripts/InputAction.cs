using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InputAction {
    [SerializeField] private KeyCode key;
    [SerializeField] private GameState state;
    [SerializeField] private Command cmd;

    public KeyCode Key {get{return key;} set{key = value;}}
    public GameState State {get{return state;} set{state = value;}}
    public Command Cmd {get{return cmd;} set{cmd = value;}}
}
