using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetActive : MonoBehaviour
{
    [SerializeField] private GameObject questionCanvas;
    [SerializeField] private GameObject answerCanvas;
    [SerializeField] private GameObject managerPlayer;
    [SerializeField] private bool isQuestionCanvasActive = false;
    private void Start()
    {
        managerPlayer = this.gameObject;
    }
    public void SetActiveFalse()
    {
        if (isQuestionCanvasActive)
        {
            questionCanvas.SetActive(false);
            answerCanvas.SetActive(true);
            isQuestionCanvasActive = false;
        }
        else if (answerCanvas.activeSelf)
        {
            answerCanvas.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("面倒贸府");
        if(collision.CompareTag("Player") && !isQuestionCanvasActive && collision.gameObject != managerPlayer)
        {
            questionCanvas.SetActive(true);
            isQuestionCanvasActive = true; 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("面倒贸府");
        if (collision.CompareTag("Player") && isQuestionCanvasActive)
        {
            questionCanvas.SetActive(false);
            isQuestionCanvasActive = false;
        }
    }
}
