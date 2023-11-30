using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUD : MonoBehaviour
{

    [SerializeField] private GameObject overviewMap;
    [SerializeField] private GameObject endMenu;

    public bool CursorEnabled
    {
        set
        {
            Cursor.visible = value;
            if(value == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    void Start()
    {
        if(overviewMap.activeSelf == true)
        {
            ToggleOverviewMap();
        }
    }

    private void Update()
    {
        if(Input.GetButtonDown("Toggle Map") == true)
        {
            ToggleOverviewMap();
        }
    }

    public bool ToggleOverviewMap()
    {
        overviewMap.SetActive(!overviewMap.activeSelf);
        return overviewMap.activeSelf;
    }
    
}
