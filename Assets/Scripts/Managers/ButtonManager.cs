using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Three States to Buttons:
// - Category is a container
// - Options is the specific dialogue options
// - Reply is when the 

public enum ButtonState {
    Category,
    Options,
    Reply
}

public class ButtonManager : MonoBehaviour {
    
    public GameObject buttonPrefab;
    public Text[] buttons;
    public ButtonState state;
    
    private void Start()
    {
        
    }
    public void PlayerInput(int buttonInput) {
        if(state == ButtonState.Category)
        {
            state = ButtonState.Options;
            //send to globalmanager
        }
        else
        {
            //Gamemanager.Ask(buttonInput);
        }
    }
}