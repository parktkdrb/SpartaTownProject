using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject inputCanvas;
    [SerializeField] private GameObject ChangecharacterCanvas;
    [SerializeField] private GameObject ChangenameCanvas;
    [SerializeField] private GameObject attendanceCanvas;
    [SerializeField] public TextMeshProUGUI nameText;

    public void InputCanvasOpen()
    {
        inputCanvas.SetActive(true);
    }
}
