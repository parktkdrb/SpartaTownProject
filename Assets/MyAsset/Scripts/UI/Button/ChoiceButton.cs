using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiceButton : ButtonManager
{
    public void ChangeButton()
    {
        ChangeButton(this.gameObject);
    }
    public void NameChange()
    {
        UIManager uiManager = gameObject.transform.root.GetComponent<UIManager>();
        uiManager.nameText.text = GameManager.Instance.name;
    }
}