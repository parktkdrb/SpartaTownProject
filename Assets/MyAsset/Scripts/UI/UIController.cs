using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private Text txt;

    public void ChangeName()
    {
        StartUI(input);
        SceneManager.LoadScene("MainScene");
        

    }
    public void StartUI(InputField _inputfield)
    {
        GameManager.Instance.name = _inputfield.text;
    }


}
