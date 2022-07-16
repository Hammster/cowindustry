using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        this.clickHandler();
    }

    void clickHandler() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null && raycastHit.transform.gameObject.tag == "Clickable")
                {
                    this.clickDispatcher(raycastHit.transform.gameObject);
                }
            }
        }
    }

    void clickDispatcher(GameObject target)
    {
        PlotHandler ph = target.GetComponent<PlotHandler>();

        if(ph)
        {
            ph.onClick();
        }
        else 
        {
            target.name = "hit";
        }
    }
}
