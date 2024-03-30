using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointDetect : MonoBehaviour
{
    [SerializeField] checkpoint _checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Checkpoint1")
        {
            _checkpoint.ResetBlockers();
        }
        else if (other.gameObject.name == "Checkpoint2")
        {
            _checkpoint.ActiveBlocker2();
        }
    }
}
