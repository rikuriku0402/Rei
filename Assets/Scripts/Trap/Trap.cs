using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour, IDamageAble
{
    public void Damage()
    {
        Debug.Log("死");
    }
}
