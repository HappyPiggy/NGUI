using UnityEngine;
using System.Collections;



public enum GameGrade
{
    EASY,
    NORMAL,
    DIFFICULTY
}

public enum ControlType
{
    KEYBOARD,
    TOUCH,
    MOUSE
}

public class GameSetting : MonoBehaviour {

    public float volume = 1;
    public GameGrade grade = GameGrade.EASY;
    public ControlType type = ControlType.KEYBOARD;
    public bool isFull = true;



    public void OnVolumeChanged()
    {
      //  Debug.Log("test1");
        volume=UIProgressBar.current.value;
    }

    public void OnGameGradeChanged()
    {
       // Debug.Log("test2");
        switch (UIPopupList.current.value)
        {
            case "简单":
                grade = GameGrade.EASY;
                break;
            case "一般":
                grade = GameGrade.NORMAL;
                break;
            case "困难":
                grade = GameGrade.DIFFICULTY;
                break;
        }
    }

    public void OnControlTypeChanged()
    {
       // Debug.Log("test3");

        switch (UIPopupList.current.value)
        {
            case "鼠标":
                type = ControlType.MOUSE;
                break;
            case "键盘":
                type = ControlType.KEYBOARD;
                break;
            case "触摸":
                type = ControlType.TOUCH;
                break;
        }
    }

    public void OnIsFullChanged()
    {
        //Debug.Log("test4");
        isFull = UIToggle.current.value;
    }
}
