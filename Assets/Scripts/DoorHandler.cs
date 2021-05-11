using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    private Animator door;
    public bool locked = true;

    // Start is called before the first frame update
    void Start()
    {
        door = gameObject.GetComponent<Animator>();
    }
    public void unlock()
    {
        locked = false;
    }
    public void locking()
    {
        locked = true;
    }

    public void Interact()
    {
        if (locked == false)
            door.SetBool("character_nearby", true);
        else
            door.SetBool("character_nearby", false);
    }

    public void freedom()
    {
        if (door.GetBool("character_nearby") == false)
            door.SetBool("character_nearby", true);
        else
            door.SetBool("character_nearby", false);
    }
}
