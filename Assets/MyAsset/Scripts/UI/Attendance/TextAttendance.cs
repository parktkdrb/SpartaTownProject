using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAttendance : MonoBehaviour
{
    public GameObject parentObj;
    public GameObject textPrefab;

    private List<GameObject> playerList = new List<GameObject>();

    private void Start()
    {
        // �ʱ� �÷��̾� ��� ����
        UpdatePlayerList();
    }

    public void PlayerListOpen()
    {
        // ���� �ڽ� ������Ʈ ����
        foreach (Transform child in parentObj.transform)
        {
            Destroy(child.gameObject);
        }

        // ���� �÷��̾� ��� ������Ʈ
        UpdatePlayerList();

        // �θ� ������Ʈ Ȱ��ȭ
        parentObj.transform.parent.gameObject.SetActive(true);

        // �ؽ�Ʈ ��ġ ������ ���� ����
        float startY = 0f; // �θ� ������Ʈ�� y ��ġ (�⺻��)
        float spacing = -50f; // �� �ؽ�Ʈ ���� ����

        foreach (var player in playerList)
        {
            // �÷��̾� �̸��� ���� �ؽ�Ʈ UI ��� ����
            GameObject textIns = Instantiate(textPrefab, parentObj.transform);
            TextMeshProUGUI tmpText = textIns.GetComponent<TextMeshProUGUI>();
            tmpText.text = player.name; // �÷��̾� �̸� ����

            // �ؽ�Ʈ ��ġ ����
            RectTransform rectTransform = textIns.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, startY); // X�� 0, Y�� startY�� ����

            startY += spacing; // ���� �ؽ�Ʈ�� Y ��ġ�� ����
        }
    }

    private void UpdatePlayerList()
    {
        playerList.Clear(); // ���� �÷��̾� ����Ʈ�� ���
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player"); // ���� �ִ� ��� �÷��̾ ������
        playerList.AddRange(players); // �÷��̾� ����Ʈ�� �߰�
    }

    public void PlayerListClose()
    {
        parentObj.transform.parent.gameObject.SetActive(false);
    }
}