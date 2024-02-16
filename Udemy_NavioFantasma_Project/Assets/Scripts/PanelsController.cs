using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsController : MonoBehaviour
{
    public GameObject aPanel;
    public GameObject dPanel;

    public void Activate()
    {
        aPanel.SetActive(true);
    }

    public void Desactivate()
    {
        dPanel.SetActive(false);
    }
}
