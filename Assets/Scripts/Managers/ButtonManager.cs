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
    public Transform buttonParent;
    public List<Text> buttons = new List<Text>();
    public ButtonState state;
    
    private void Start()
    {
        CreateBtn();
    }
    public void UpdateScreen(List<string>NewButtons)
    {
        //if(buttons.Count == ) {}
    }
    private void CreateBtn()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(buttonPrefab, new Vector3(-100 + (i * 50), -400), Quaternion.identity, buttonParent);            
        }
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