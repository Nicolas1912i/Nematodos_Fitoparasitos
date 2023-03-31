using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedDoublePanelsControl : MonoBehaviour
{
    [SerializeField] GameObject informationPanel;
    [SerializeField] GameObject imageMoving;
    [SerializeField] GameObject imageMoving_1;

    void Start()
    {
        imageMoving.SetActive(false);
        imageMoving_1.SetActive(false);
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

    public void OpenBigImage_1()
    {
        informationPanel.SetActive(false);
        imageMoving_1.SetActive(true);
    }

    public void CloseBigImage()
    {
        informationPanel.SetActive(true);
        imageMoving.SetActive(false);
    }

    public void CloseBigImage_1()
    {
        informationPanel.SetActive(true);
        imageMoving_1.SetActive(false);
    }
}
