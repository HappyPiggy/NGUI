using UnityEngine;
using System.Collections;

public class CellsManager : MonoBehaviour {

    public GameObject[] cells;
    public string[] equipsName;
    public GameObject item;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PickUp();
            
        }
    }

    void PickUp()
    {
        int index = Random.Range(0, equipsName.Length);
        string name = equipsName[index];
        bool isRepeat = false;


        for (int i = 0; i < cells.Length; i++)
        {
            //如果已经有物品就加数量
            if (cells[i].transform.childCount > 0)
            {
                knapsack item = cells[i].GetComponentInChildren<knapsack>();
                if (item.sprite.spriteName == name)
                {
                    Debug.Log("找到相同");
                    item.AddNumber(1);
                    isRepeat = true;
                    break;
                }
             
            }
        }


        if (!isRepeat)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                Debug.Log("多了个物品");
                //如果背包格子没物品  添加物品
                if (cells[i].transform.childCount == 0)
                {
                    GameObject go = NGUITools.AddChild(cells[i], item);
                    go.GetComponent<UISprite>().spriteName = name;
                    break;
                }
            }
        }
            
    }
}
