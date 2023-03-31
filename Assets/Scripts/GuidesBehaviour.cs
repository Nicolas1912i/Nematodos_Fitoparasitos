using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuidesBehaviour : MonoBehaviour
{
    [SerializeField] Canvas mainCanvas;
    [Header("Lists")]
    [SerializeField] List<GameObject> mainButtons;
    [SerializeField] List<GameObject> prefabs;
    List<GameObject> created;
    [Header("Required Panel Int")]
    [SerializeField] int activatorInt = 100;

    void Start()
    {
        foreach (GameObject gameObject in mainButtons)
        {
            gameObject.GetComponent<Button>().onClick.AddListener(() => Paneles());
        }
    }

    public void RequestPanel(int index) { activatorInt = index; }

    void Paneles()
    {
        Instantiate(prefabs[activatorInt]);
    }
}
