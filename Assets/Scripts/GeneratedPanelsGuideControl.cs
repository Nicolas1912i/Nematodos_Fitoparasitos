using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedPanelsGuideControl : MonoBehaviour
{

    [SerializeField] GameObject informationPanel;
    [SerializeField] GameObject imageMoving;

    void Start()
    {
        imageMoving.SetActive(false);
    }

    public void HideCanvas()
    {
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    public void OpenBigImage()
    {
        informationPanel.SetActive(false);
        imageMoving.SetActive(true);
    }

    public void CloseBigImage()
    {
        informationPanel.SetActive(true);
        imageMoving.SetActive(false);
    }
}
