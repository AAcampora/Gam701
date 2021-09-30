using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    public SlotHandler[] slots;
    public bool isEverythingCorrect;
    public int questionNum = 0;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < slots.Length; i++) {
            if (slots[i].isCorrect)
            {
                questionNum++;
            }   
        }

        isEverythingCorrect = questionNum >= slots.Length ? true : false;
    }
}
