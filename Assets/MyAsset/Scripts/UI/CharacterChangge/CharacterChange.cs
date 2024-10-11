using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChange : MonoBehaviour
{
    [SerializeField] private GameObject characterChangeUI;
    [SerializeField] private GameObject inputUI;
    [SerializeField] private Image mainsprite;
    [SerializeField] private Image spriteChoice;
    public void CharacterChangeButton()
    {
        GameManager.Instance.spritename = mainsprite.sprite.name;
        foreach (Sprite item in GameManager.Instance.sprites)
        {
            if(item.name == mainsprite.sprite.name)
            {
                spriteChoice.sprite = item;
                break;
            }
        }
        inputUI.SetActive(true);
        characterChangeUI.SetActive(false);
    }
    public void UIOpenCharacter()
    {
        inputUI.SetActive(false);
        characterChangeUI.SetActive(true);
        
    }
}