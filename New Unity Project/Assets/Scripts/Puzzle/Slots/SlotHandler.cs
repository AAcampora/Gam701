using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotHandler : MonoBehaviour, IDropHandler {

    public bool isCorrect = false;
    public string correctAnswer;
    public string capturedText;
    public PointerEventData obj;
    public SlotManager SM;

    private void Awake()
    {
        SM = this.gameObject.GetComponentInParent<SlotManager>();
    }
    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {

            //Place object in the right position
            AnchorTextToSlot(eventData);
            //check if text is correct
            CheckAnswer(eventData);

            if (SM != null) {
                SM.ValidateResponse();
            }
        }
    }

    private PointerEventData AnchorTextToSlot(PointerEventData data) {
        var textToSlot = data.pointerDrag.GetComponent<RectTransform>();
        textToSlot.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

        return data;
    }

    private bool CheckAnswer(PointerEventData data)
    {
        capturedText = data.pointerDrag.GetComponent<Text>().text;
        return isCorrect = correctAnswer == capturedText ? true : false;
    }
}
