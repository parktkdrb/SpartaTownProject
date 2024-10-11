using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public GameObject playerPrefab;
    [SerializeField] public GameObject playernameCanvasPrefab;

    public GameObject playerInstance;
    public GameObject playernameCanvasInstance;
    private TextMeshProUGUI playerNameText;
    [SerializeField] private List<GameObject> playerObjList;
    private void Awake()
    {
        PlayerIns();
        
    }

    private void PlayerIns()
    {
        // Instantiate�� ������ ��ü�� ������ ������ ����
        playerInstance = Instantiate(playerPrefab);
        playernameCanvasInstance = Instantiate(playernameCanvasPrefab);

        // �÷��̾� �̸� ����
        playerInstance.name = GameManager.Instance.name;
        SpriteRenderer playersp = playerInstance.GetComponentInChildren<SpriteRenderer>();
        playerNameText = playernameCanvasInstance.GetComponentInChildren<TextMeshProUGUI>();

    }
    private void FixedUpdate()
    {// GameManager�� name ���� ����Ǿ��� �� UI�� �����մϴ�.
        if (playerNameText.text != GameManager.Instance.name || playerInstance.name != GameManager.Instance.name)
        {
            Debug.Log("�̸� ����");
            playerNameText.text = GameManager.Instance.name;
            playerInstance.name = GameManager.Instance.name;
        }

        playernameCanvasInstance.transform.position = playerInstance.transform.position + new Vector3(0, 0.5f, 0);
    }
}
