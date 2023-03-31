using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectorSystem : MonoBehaviour
{

    [SerializeField] Canvas mainCanvas;

    [Header("GameObjects/Prefabs")]
    [SerializeField] List<GameObject> prefabs;
    [SerializeField] GameObject[] _behindStuff;

    [Header("Images List")]
    [SerializeField] List<Sprite> figuresImages;

    [Header("Buttons List")]
    [SerializeField] List<Button> figuresButtons;

    [Header("Guide Scenes String Name List")]
    List<string> guideSceneNames = new List<string> { "Guide_1a", "Guide_1b", "Guide_2a", "Guide_2b", "Guide_3a", "Guide_3b", "Guide_3c", "Guide_3d",
                                                      "Guide_3e", "Guide_3f", "Guide_3g", "Guide_4", "Figure_13", "Guide_5", "Figure_15", "Figure_16",
                                                      "Guide_6a", "Figure_18", "Figure_19", "Figure_20", "Figure_21", "Figure_22", "Figure_23",
                                                      "Guide_6b", "Figure_25", "Guide_6c", "Figure_27", "Figure_28", "Figure_29", "Figure_30",
                                                      "Guide_6d", "Figure_32", "Figure_33", "Figure_34", "Guide_6e", "Figure_36", "Figure_37",
                                                      "Figure_38", "Guide_7a", "Figure_40", "Guide_7b", "Figure_42", "Guide_7c", "Figure_44", "Figure_45",
                                                      "Guide_8", "Figure_47", "Guide_9", "Figure_49", "Guide_10a", "Guide_10b", "Figure_52", "Guide_11a",
                                                      "Guide_11b", "Guide_12a", "Figure_56", "Guide_12b", "Guide_13a", "Figure_59", "Figure_60",
                                                      "Guide_13b", "Guide_14a", "Guide_14b", "Guide_15a", "Guide_15b", "Guide_16", "Figure_67",
                                                      "Guide_17a", "Figure_69", "Guide_17b", "Figure_71", "Guide_18a", "Guide_18b", "Guide_19", "Figure_75" };

    [Header("Required Panel Int")]
    [SerializeField] int activatorInt;

    [Header("Generated Panels")]
    List<GameObject> generatedPanels = new List<GameObject>();

    [Header("Generated Panels Properties")]
    TextMeshProUGUI _title;
    Button _atlasButton;
    Button _guideButton;

    [Header("Temporal Information")]
    string _buttonText;

    SceneTransitions transitive;

    [SerializeField] GameObject videosPanel;

    private void Start()
    {
        foreach(Button button in figuresButtons)
        {
            button.onClick.AddListener(() => Paneles());
        }
    }

    public void RequestPanel(int index) { activatorInt = index; }

    void Paneles()
    {
        Instantiate(prefabs[activatorInt]);
    }

    public void Videos()
    {
        Instantiate(videosPanel);
    }

}
