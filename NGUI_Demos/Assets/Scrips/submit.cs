using UnityEngine;
using System.Collections;

public class submit : MonoBehaviour {

    private UIInput uiInput;
    public UITextList textList;

    void Awake()
    {
        uiInput = GetComponent<UIInput>();
    }


   public void OnSubmitClick()
    {
        string submit = uiInput.value;
        textList.Add(submit);
        uiInput.value = "";
    }
}
