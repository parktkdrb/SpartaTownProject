using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAttendance : MonoBehaviour
{
    public GameObject parentObj;
    private PlayerListManager playerListManager;

    public GameObject textPrefab;
    private void Start()
    {
        playerListManager = GameManager.Instance.playerList;
    }

    public void PlayerListOpen()
    {
        parentObj.transform.parent.gameObject.SetActive(true);
        foreach (var player in playerListManager.players)
        {
            float startY = 0f; // �θ� ������Ʈ�� y ��ġ (�⺻��)
            float spacing = -50f; // �� �ؽ�Ʈ ���� ����
            // �÷��̾� �̸��� ���� �ؽ�Ʈ UI ��� ����
            GameObject textIns = Instantiate(textPrefab, parentObj.transform);
            TextMeshProUGUI tmpText = textIns.GetComponent<TextMeshProUGUI>();
            tmpText.text = player.playername; // �÷��̾� �̸� ����

            // �ؽ�Ʈ ��ġ ����
            RectTransform rectTransform = textIns.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, startY); // X�� 0, Y�� startY�� ����

            startY += spacing; // ���� �ؽ�Ʈ�� Y ��ġ�� ����
        }
    }
    public void PlayerListClose()
    {
        parentObj.transform.parent.gameObject.SetActive(false);

    }
}