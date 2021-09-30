using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour, IDropHandler {

    public bool isCorrect = false;
    public string correctAnswer;
    public string capturedText;
    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;

            capturedText = eventData.pointerDrag.GetComponent<Text>().text;

            Debug.Log(eventData.pointerDrag.GetComponent<Text>().text);
        }
    }

    private void Update() {
        isCorrect = correctAnswer == capturedText ? true : false;
    }
}
