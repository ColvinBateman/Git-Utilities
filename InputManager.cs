using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour {
    public Text outText;//defining the text as it comes out of unity, being from a textbox
    public InputField textIn;//defining the text you put into unity
    public Button enterButton;//defining a button being enterButton

	// Use this for initialization
	void Start () {
        outText.text = "";//makes the textbox clear on start
	}
	
    public void EnterPressed()
    {
        //outText.text = textIn.text;//textbox is what is put into the textbox from the user
        outText.text = Utilities.ProcessText(textIn.text);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
