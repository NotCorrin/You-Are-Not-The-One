using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    Intro,
    Select,
    Question,
    Minor,
    Major
}

public class TheManager : MonoBehaviour
{
    public GameState gameState;
    public Girl selectedGirl;
    [SerializeField] List<Girl> girls = new List<Girl>();
    

    void Start()
    {
        #region Initial Values
        gameState = GameState.Intro;
        #endregion

        #region Girls
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Girl")) {
            girls.Add(gameObject.GetComponent<Girl>());
        }
        FindSelectedGirl();
        #endregion
    }

    void Update()
    {
        
    }

    // Function will loop over every girl to find "selected" bool
    void FindSelectedGirl() {
        foreach (Girl girl in girls) {
            if (girl.selected) {
                selectedGirl = girl;
            }
        }
    }
}
