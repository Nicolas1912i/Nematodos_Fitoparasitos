using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguresIndexControl : MonoBehaviour
{

    ToastController _toaster;
    [Header("Movable Scroll View")]
    [SerializeField] RectTransform _rectTransform;
    [Header("Panel Indexer Values")]
    [SerializeField] GameObject _panel;
    [SerializeField] GameObject[] _behindStuff;
    float[] _positions = new float[] { 6.011963f, 339.674f, 676.3419f, 1863.698f, 8801.464f, 9144.144f, 10325.49f, 10662.16f, 10998.82f, 12017.85f, 12357.52f };

    void Start()
    {
        HidePanel();
        _toaster = FindObjectOfType<ToastController>().GetComponent<ToastController>();
    }

    public void GoToSection(int sectionIndex)
    {
        _rectTransform.anchoredPosition = new Vector2(_rectTransform.anchoredPosition.x, _positions[sectionIndex]);
        HidePanel();
    }

    public void ShowPanel()
    {
        _panel.SetActive(true);
        foreach (GameObject gameObject in _behindStuff) { gameObject.SetActive(false); }
    }

    public void HidePanel()
    {
        _panel.SetActive(false);
        foreach (GameObject gameObject in _behindStuff) { gameObject.SetActive(true); }
    }
}
