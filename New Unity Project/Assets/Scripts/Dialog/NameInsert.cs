using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NameInsert : MonoBehaviour
{
    public Flowchart fc;
    public Character ch;
    public void SaveName(string name)
    {
        fc.SetStringVariable("player", name);
        fc.SetBooleanVariable("nameEntered", true);
    }
}
