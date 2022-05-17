using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Jogador : MonoBehaviour, IPausable
{
    private MouseLook rato;
    public FirstPersonController fps;

    void Start()
    {
        rato = fps.m_MouseLook;
    }

    public void SetMover(bool estado)
    {
        rato.SetCursorLock(estado);
        fps.SetMoving(estado);
        fps.SetRotate(estado);
    }

    public void OnPause(bool state)
    {
        Debug.Log("Chamou pausable: "+state);
        SetMover(!state);
    }
}
