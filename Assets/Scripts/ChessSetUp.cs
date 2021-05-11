using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessSetUp : MonoBehaviour
{
    public GameObject projector;
    public int missing_pieces = 4;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chess")
            missing_pieces -= 1;
        if (missing_pieces == 0)
            projector.GetComponent<ProjectorHandler>().fixit();
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chess")
            missing_pieces += 1;
    }
}
