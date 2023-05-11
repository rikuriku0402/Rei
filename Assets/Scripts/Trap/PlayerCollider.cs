using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageAble damage))
        {
            damage.Damage();
        }
        else if (other.TryGetComponent(out IGoalAble goal))
        {
            goal.Goal();
        }
    }
}
