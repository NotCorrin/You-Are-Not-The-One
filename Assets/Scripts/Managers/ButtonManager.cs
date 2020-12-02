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
    
    //public GameObject buttonPrefab;
    public Transform buttonParent;
    public RectTransform[] btnTransform;
    private int buttonCount;
    private Text[] btnText = new Text[5];
    private InputManager inputManager;
    public ButtonState state;
    
    private void Start()
    {
        inputManager = GetComponent<InputManager>();
        CreateBtn();
        inputManager.getBtn(0);
    }
    public void UpdateScreen(List<string> NewButtons)
    {
        if (buttonCount == NewButtons.Count) return;
        buttonCount = NewButtons.Count;
        for (int i = 0; i < 5; i++)
        {
            //update button position
            btnTransform[i].gameObject.SetActive(i < buttonCount);

            //update button text
            if (i < buttonCount)
            {
                //btnTransform[i].anchoredPosition = new Vector3(((buttonCount + 1) * -50) + ((i + 1) * 100), 0);
                btnTransform[i].anchoredPosition = new Vector3(0, i * -50 -25);
                btnText[i].text = NewButtons[i];
            }
        }
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
            UpdateScreen(inputManager.getBtn(i));
        }
        else
        {
            //Gamemanager.Ask(buttonInput);
        }
        Debug.Log("clicked on " + i);
    }
}