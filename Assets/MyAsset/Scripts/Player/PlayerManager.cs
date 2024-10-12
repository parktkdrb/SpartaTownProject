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
    private SpriteRenderer playerSp;
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
        playerSp = playerInstance.GetComponentInChildren<SpriteRenderer>();
        playerNameText = playernameCanvasInstance.GetComponentInChildren<TextMeshProUGUI>(); 
        SpriteChange();
    }
    private void FixedUpdate()
    {
        if (playerNameText.text != GameManager.Instance.name || playerInstance.name != GameManager.Instance.name)
        {
            playerNameText.text = GameManager.Instance.name;
            playerInstance.name = GameManager.Instance.name;
        }


    }
    public void SpriteChange()
    {


        // 1. playerSp sprite�� GameManger sprite �̸� ��
        // 2. �ٸ��� playerObjList�� ������Ʈ�� ���������� ���鼭
        // 3. playerInstane �ı� �� ���� ��������Ʈ �̸��� ������ ����
        // 4. ������ �����ϱ� ����ó�� ����.
        if (playerSp.sprite.name != GameManager.Instance.spritename)
        {
            // ������ �̸� ĵ������ �÷��̾� �ν��Ͻ��� �ı�
            Destroy(playerInstance);

            // ������Ʈ ����Ʈ ��ȸ
            foreach (GameObject item in playerObjList)
            {
                // item�� ��������Ʈ �̸� ��������
                Sprite sp = item.GetComponentInChildren<SpriteRenderer>().sprite;

                // �̸��� GameManager�� ����� ��������Ʈ �̸��� ������ ��
                if (sp.name == GameManager.Instance.spritename)
                {
                    // ���ο� �÷��̾� �ν��Ͻ� ����
                    playerInstance = Instantiate(item);
                    playerSp = playerInstance.GetComponentInChildren<SpriteRenderer>(); // playerSp ���Ҵ�
                    break; // ��ġ�ϴ� ������Ʈ�� ã�����Ƿ� ���� ����
                }
            }
        }
    }
}
