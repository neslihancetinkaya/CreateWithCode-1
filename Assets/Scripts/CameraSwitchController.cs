using System;
using UnityEngine;

public class CameraSwitchController : MonoBehaviour
{
    [SerializeField] private GameObject SeatCam;
    private bool _isCamActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SeatCam.SetActive(!_isCamActive);
            _isCamActive = !_isCamActive;
        }
    }
}