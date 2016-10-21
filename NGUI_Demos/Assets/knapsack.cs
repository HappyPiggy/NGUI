using UnityEngine;
using System.Collections;

public class knapsack :UIDragDropItem {

    public UISprite sprite;
    public UILabel label;

    private int number=1;

    public void AddNumber(int nb)
    {
        number += nb;
        label.text = number + "";
        print(number);
    }

    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        print(surface.tag);

        if (surface.tag == "Cell")
        {
            transform.parent = surface.transform;
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag == "Goods")
        {
            Transform parent = transform.parent;
            transform.parent = surface.transform.parent;
            transform.localPosition = Vector3.zero;

            surface.transform.parent = parent;
            surface.transform.localPosition = Vector3.zero;
        }
    }

}
