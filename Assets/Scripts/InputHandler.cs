using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    private GameManager gm = null;
    [SerializeField] private List<InputAction> actions = new List<InputAction>();

    // Use this for initialization
    void Start () {
        Init();
	}

    private void Init() {
        gm = GameManager.Instance;
    }

    // Update is called once per frame
    void Update () {
        foreach (InputAction action in actions) {
            if (Input.GetKeyDown(action.Key)) {
                if (gm.CurrentState == action.State) {
                    action.Cmd.Execute();
                }
            }
        }
	}
}
