using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos : MonoBehaviour
{
    public bool isgruonded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isgruonded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isgruonded = false;
    }
}
