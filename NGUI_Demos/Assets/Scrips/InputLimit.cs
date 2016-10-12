using UnityEngine;
using System.Collections;

public class InputLimit : MonoBehaviour {

    private UIInput ageInput;

    void Awake()
    {
        ageInput = GetComponent<UIInput>();
    }



  public  void AgeLimit()
    {
        string ageRaw = ageInput.value;
        int age = int.Parse(ageRaw);

        if (age > 120)
            ageInput.value = "100";

        if (age < 18)
            ageInput.value = "18";
    }
}
