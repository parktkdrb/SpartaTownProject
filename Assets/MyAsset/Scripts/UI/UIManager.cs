using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject inputCanvas;
    private InputField input;
    public GameObject nameTxtCanvas;
    private GameObject backGroundUI;
    public TextMeshProUGUI txt;
    private void Awake()
    {
        txt = nameTxtCanvas.GetComponentInChildren<TextMeshProUGUI>();
        inputCanvas = gameObject.transform.GetChild(0).gameObject;
        input = inputCanvas.GetComponentInChildren<InputField>();
        nameTxtCanvas = gameObject.transform.GetChild(1).gameObject;
        backGroundUI = gameObject.transform.GetChild(2).gameObject;
        nameTxtCanvas.SetActive(false);
        backGroundUI.SetActive(false);

    }

    public void ChangeName()
    {
        GameManager.Instance.name = input.text;
        inputCanvas.SetActive(false);
        txt.text = input.text;
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            backGroundUI.SetActive(true);
            SceneManager.LoadScene("MainScene");
        }
        nameTxtCanvas.SetActive(true);
    }
    public void ChangeNameUIOpen()
    {
        inputCanvas.gameObject.SetActive(true);
        txt.text = input.text;
        nameTxtCanvas.SetActive(false);

    }

}
