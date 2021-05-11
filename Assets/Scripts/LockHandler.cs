using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockHandler : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
            door.GetComponent<DoorHandler>().unlock();
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Key")
            door.GetComponent<DoorHandler>().locking();
    }
}
