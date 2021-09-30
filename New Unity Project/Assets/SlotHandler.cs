using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour, IDropHandler, IDragHandler {

    public bool isCorrect = false;
    public string correctAnswer;
    public string capturedText;
    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;

            capturedText = eventData.pointerDrag.GetComponent<Text>().text;

            Debug.Log(eventData.pointerDrag.GetComponent<Text>().text);
        }

        if (eventData.dragging == true)
        {
            capturedText = " ";
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
        {
            capturedText = " ";
        }
    }
    private void Update()
    {
        isCorrect = correctAnswer == capturedText ? true : false;
    }
}
