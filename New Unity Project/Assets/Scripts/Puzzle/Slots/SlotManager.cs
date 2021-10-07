using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SlotManager : MonoBehaviour
{
    [SerializeField]
    private SlotHandler[] slots;

    public Flowchart fc;

    public bool ValidateResponse()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i].isCorrect == false)
            {
                return false;
            }
        }

        return true;
    }

    private void Update()
    {
        if (ValidateResponse())
        {
            fc.SetBooleanVariable("isPuzzle", true);
        }
    }

}
