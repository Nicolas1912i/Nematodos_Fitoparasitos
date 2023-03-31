using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ParasiteController : MonoBehaviour
{
    [Header("Estructura Esqueletal (Opacos)")]
    [SerializeField] GameObject s_Cabezal_Opaque;
    [SerializeField] GameObject s_Exteriores_Opaque;
    [SerializeField] GameObject s_Interior_Amarillo_Opaque;
    [SerializeField] GameObject s_Interior_Azul_Opaque;
    [SerializeField] GameObject s_Interior_Rojo_Opaque;
    [SerializeField] GameObject s_Toroides_Anillares_Opaque;
    [Header("Panel Properties")]
    [SerializeField] GameObject panelItself;
    [SerializeField] GameObject structure;
    [SerializeField] GameObject animators;
    [Header("Structure Toggles")]
    [SerializeField] List<Toggle> toggles;
    [Header("Materials Dropdowns")]
    [SerializeField] List<TMP_Dropdown> dropdowns;

    [SerializeField] Animator animator;
    bool heyYes = false;

    public void ShowPanel()
    {
        panelItself.SetActive(true);
        structure.SetActive(true);
        animators.SetActive(false);
    }

    public void HidePanel() { panelItself.SetActive(false); }

    void Start()
    {
        panelItself.SetActive(false);
        EstadoQuo();
    }

    void Update()
    {
        void StructureToggles()
        {
            s_Exteriores_Opaque.transform.GetChild(0).gameObject.SetActive(toggles[0].isOn);
            foreach (Transform transform in s_Toroides_Anillares_Opaque.transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[1].isOn; }
            foreach (Transform transform in s_Cabezal_Opaque.transform.GetChild(0).transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[3].isOn; }
            s_Cabezal_Opaque.transform.GetChild(1).gameObject.SetActive(toggles[4].isOn);
            s_Exteriores_Opaque.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = toggles[5].isOn;
            s_Interior_Amarillo_Opaque.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = toggles[6].isOn;
            s_Interior_Amarillo_Opaque.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = toggles[7].isOn;
            s_Exteriores_Opaque.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = toggles[8].isOn;
            foreach (Transform transform in s_Interior_Azul_Opaque.transform.GetChild(0).transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[9].isOn; }
            foreach (Transform transform in s_Interior_Azul_Opaque.transform.GetChild(1).transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[10].isOn; }
            s_Exteriores_Opaque.transform.GetChild(3).GetComponent<MeshRenderer>().enabled = toggles[11].isOn;
            foreach (Transform transform in s_Interior_Rojo_Opaque.transform.GetChild(0).transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[12].isOn; }
            foreach (Transform transform in s_Interior_Rojo_Opaque.transform.GetChild(1).transform) { transform.GetComponent<MeshRenderer>().enabled = toggles[13].isOn; }
        }
        StructureToggles();
    }

    public void ShowStructureGroup()
    {
        structure.SetActive(true);
        animators.SetActive(false);
    }

    public void ShowAnimationsGroup()
    {
        structure.SetActive(false);
        animators.SetActive(true);
    }

    public void FirstAnimation()
    {
        animator.Play("Diffusing_Out_Inside");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().enabled = false;
        StartCoroutine(enumerator());
        if (heyYes)
        {
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(-4.25f, 0.89f, 0.8f);
            GameObject.FindGameObjectWithTag("MainCamera").transform.eulerAngles = new Vector3(10.313f, 98.766f, 0f);
        }
    }

    public void SecondAnimation()
    {
        animator.Play("Separating_Interior_Exterior");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().enabled = true;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().Play("Orbiting");
    }

    public void EstadoQuo()
    {
        animator.Play("Idle");
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().enabled = false;
        StartCoroutine(enumerator());
        if (heyYes)
        {
            GameObject.FindGameObjectWithTag("MainCamera").transform.position = new Vector3(-4.25f, 0.89f, 0.8f);
            GameObject.FindGameObjectWithTag("MainCamera").transform.eulerAngles = new Vector3(10.313f, 98.766f, 0f);
        }
    }

    IEnumerator enumerator()
    {
        heyYes = true;
        yield return new WaitForEndOfFrame();
        heyYes = false;
    }
}
