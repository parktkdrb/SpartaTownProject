using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private PlayerListManager playerListManager;
    private void Start()
    {
        playerListManager = GameObject.Find("GameManager").GetComponent<PlayerListManager>();
    }
    public virtual void ChangeButton(GameObject _gameObject)
    {
        InputField inputfield = _gameObject.GetComponentInParent<InputField>();
        string newName = inputfield.text;

        if (!string.IsNullOrEmpty(newName))
        {
            GameManager.Instance.name = newName;
            playerListManager.AddPlayer(newName);
            inputfield.gameObject.SetActive(false);
        }
    }
    public void JoinButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
