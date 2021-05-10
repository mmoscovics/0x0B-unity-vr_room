using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    private Animator door;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponent<Animator>();
    }

    public void Interact()
    {
        if (door.GetBool("character_nearby") == false)
            door.SetBool("character_nearby", true);
        else
            door.SetBool("character_nearby", false);
    }
}
