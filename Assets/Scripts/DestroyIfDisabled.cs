using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfDisabled : MonoBehaviour
{
    public bool SelfDestructionEnabled { get; set; } = false;

    public void OnDisable()
    {
        if (SelfDestructionEnabled)
            Destroy(gameObject);
    }
}
