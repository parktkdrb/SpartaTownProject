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
    [SerializeField] private PlayerManager playerManager;
    public void StartChangeButton()
    {
        foreach (Sprite item in GameManager.Instance.sprites)
        {
            if (item.name == mainsprite.sprite.name)
            {
                spriteChoice.sprite = item;
                break;
            }
        }
        GameManager.Instance.spritename = mainsprite.sprite.name;
        inputUI.SetActive(true);
        characterChangeUI.SetActive(false);
    }


    public void MainCharacterChangeButton()
    {
        characterChangeUI.transform.parent.gameObject.SetActive(false);
        GameManager.Instance.spritename = mainsprite.sprite.name;
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        Vector3 playerpos = playerManager.playerInstance.transform.position;
        playerManager.SpriteChange();
        playerManager.playerInstance.transform.position = playerpos;
    }
    public void UIOpenCharacter()
    {
        inputUI.SetActive(false);
        characterChangeUI.SetActive(true);

    }
}