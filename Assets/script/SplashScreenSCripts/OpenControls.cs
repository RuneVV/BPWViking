using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenControls : MonoBehaviour
{
    public GameObject ControlScreen;
    public GameObject Cross;

    public void OpenControlScreen()
    {
        ControlScreen.GetComponent<Image>().enabled = true;
        Cross.GetComponent<Image>().enabled = true;
    }

    public void CloseControlScreen()
    {
        ControlScreen.GetComponent<Image>().enabled = false;
        Cross.GetComponent<Image>().enabled = false;

    }

       


}
