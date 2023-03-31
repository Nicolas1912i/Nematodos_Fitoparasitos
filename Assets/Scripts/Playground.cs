using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playground : MonoBehaviour
{

    public List<GameObject> prefabs;
    public List<GameObject> created;

    void Start()
    {
        Instantiating();
    }

    void Update()
    {
        
    }

    void Instantiating()
    {
        foreach(GameObject gameObject in prefabs)
        {
            GameObject generated = Instantiate(gameObject);
            created.Add(generated);
        }
    }
}
