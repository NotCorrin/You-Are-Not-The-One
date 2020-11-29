using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Intro,
    Select,
    Question,
    Reply,
    Major
}

public class TheManager : MonoBehaviour
{
    public GameState gameState;
    
    void Start()
    {
        #region Initial Values
        gameState = GameState.Intro;
        #endregion
    }

    void Update()
    {
        
    }
}
