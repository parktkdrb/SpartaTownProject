using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    private void Start()
    {
    }
    public virtual void ChangeButton(GameObject _gameObject)
    {
        InputField inputfield = _gameObject.GetComponentInParent<InputField>();
        string newName = inputfield.text;

        GameManager.Instance.name = newName;
        inputfield.gameObject.SetActive(false);
        
    }
    public void JoinButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
