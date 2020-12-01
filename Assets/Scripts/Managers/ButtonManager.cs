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
    public RectTransform[] btnTransform; 
    private Text[] btnText = new Text[5];
    private InputManager inputManager;
    public ButtonState state;
    
    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        CreateBtn();
        UpdateBtnPosition(0);
        UpdateBtnPosition(3);
    }
    public void UpdateScreen(List<string>NewButtons)
    {
        //if(buttons.Count == ) {}
    }
    private void CreateBtn()
    {
        for (int i = 0; i < btnText.Length; i++)
        {
            //btnTransform[i]= (RectTransform)Instantiate(buttonPrefab, buttonParent).transform;
            //btnTransform[i].GetComponent<Button>().onClick.AddListener(delegate { GetInput(i); });
            btnText = buttonParent.GetComponentsInChildren<Text>();
        }
    }
    public void GetInput(int i)
    {
        if (state == ButtonState.Category)
        {
            state = ButtonState.Options;
            //send to globalmanager
        }
        else
        {
            //Gamemanager.Ask(buttonInput);
        }
        Debug.Log("clicked on " + i);
    }
    private void UpdateBtnPosition(int size)
    {
        int _btnCount = buttonParent.childCount;
        if (size == _btnCount) return;
        for (int i = 0; i < _btnCount; i++)
        {
            btnTransform[i].gameObject.SetActive(i < size);
            btnTransform[i].anchoredPosition = new Vector3((_btnCount * -50) + ((i+1) * 100), 0);
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