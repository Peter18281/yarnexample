using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Narrator : MonoBehaviour
{
    [YarnCommand("narr_Leave")]
    public void narrLeave()
    {
        Destroy(gameObject);
    }
}
