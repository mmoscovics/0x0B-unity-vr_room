using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorHandler : MonoBehaviour
{
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Interact()
    {
        if (particle.activeSelf == true)
            particle.SetActive(false);
        else
            particle.SetActive(true);
    }
}
