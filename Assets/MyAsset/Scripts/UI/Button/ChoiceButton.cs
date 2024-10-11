using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiceButton : ButtonManager
{

    public void ChangeButton()
    {
        JoinButton(this.gameObject);
    }
}