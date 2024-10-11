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
            float startY = 0f; // 부모 오브젝트의 y 위치 (기본값)
            float spacing = -50f; // 각 텍스트 간의 간격
            // 플레이어 이름을 가진 텍스트 UI 요소 생성
            GameObject textIns = Instantiate(textPrefab, parentObj.transform);
            TextMeshProUGUI tmpText = textIns.GetComponent<TextMeshProUGUI>();
            tmpText.text = player.playername; // 플레이어 이름 설정

            // 텍스트 위치 설정
            RectTransform rectTransform = textIns.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, startY); // X는 0, Y는 startY로 설정

            startY += spacing; // 다음 텍스트의 Y 위치를 조정
        }
    }
    public void PlayerListClose()
    {
        parentObj.transform.parent.gameObject.SetActive(false);

    }
}