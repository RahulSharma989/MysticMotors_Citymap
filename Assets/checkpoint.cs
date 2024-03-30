using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    [SerializeField] private GameObject _blocker1;
    [SerializeField] private GameObject _directionalArrowOn;
    [SerializeField] private GameObject _blocker2;
    [SerializeField] private GameObject _directionalArrowOff;

    private void Start()
    {
        ResetBlockers();
    }
    public void ResetBlockers()
    {
        _blocker1.SetActive(true);
        _directionalArrowOn.SetActive(true);
        _blocker2.SetActive(false);
        _directionalArrowOff.SetActive(false);
    }


    public void ActiveBlocker2()
    {
        _blocker1.SetActive(false);
        _directionalArrowOn.SetActive(false);
        _blocker2.SetActive(true);
        _directionalArrowOff.SetActive(true);
    }

}
