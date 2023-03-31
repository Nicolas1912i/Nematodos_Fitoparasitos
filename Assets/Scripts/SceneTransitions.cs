using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{

    [SerializeField] Animator transitionAnim;

    public void Load(int scene) { StartCoroutine(LoadScene(scene)); }

    IEnumerator LoadScene(int scene)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(scene);
    }

    public void LoadwithString(string scene) { StartCoroutine(LoadScenewithString(scene)); }

    IEnumerator LoadScenewithString(string scene)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(scene);
    }

    public void Exit() { Application.Quit(); }
}
