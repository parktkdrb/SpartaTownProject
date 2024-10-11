using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public void JoinButton(GameObject _gameObject)
    {
        InputField inputfield =_gameObject.GetComponentInParent<InputField>();
        Debug.Log(inputfield.name);
        GameManager.Instance.name = inputfield.text;
        SceneManager.LoadScene("MainScene");
    }
}
