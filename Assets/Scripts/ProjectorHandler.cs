using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorHandler : MonoBehaviour
{
    public GameObject particle;
    public bool broken = true;

    public void fixit()
    {
        broken = false;
    }

    public void Interact()
    {
        if (broken == false)
            if (particle.activeSelf == true)
                particle.SetActive(false);
            else
                particle.SetActive(true);
    }
}
