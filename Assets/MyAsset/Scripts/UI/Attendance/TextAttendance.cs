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
        // 초기 플레이어 목록 설정
        UpdatePlayerList();
    }

    public void PlayerListOpen()
    {
        // 기존 자식 오브젝트 삭제
        foreach (Transform child in parentObj.transform)
        {
            Destroy(child.gameObject);
        }

        // 기존 플레이어 목록 업데이트
        UpdatePlayerList();

        // 부모 오브젝트 활성화
        parentObj.transform.parent.gameObject.SetActive(true);

        // 텍스트 위치 조정을 위한 변수
        float startY = 0f; // 부모 오브젝트의 y 위치 (기본값)
        float spacing = -50f; // 각 텍스트 간의 간격

        foreach (var player in playerList)
        {
            // 플레이어 이름을 가진 텍스트 UI 요소 생성
            GameObject textIns = Instantiate(textPrefab, parentObj.transform);
            TextMeshProUGUI tmpText = textIns.GetComponent<TextMeshProUGUI>();
            tmpText.text = player.name; // 플레이어 이름 설정

            // 텍스트 위치 설정
            RectTransform rectTransform = textIns.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, startY); // X는 0, Y는 startY로 설정

            startY += spacing; // 다음 텍스트의 Y 위치를 조정
        }
    }

    private void UpdatePlayerList()
    {
        playerList.Clear(); // 기존 플레이어 리스트를 비움
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player"); // 씬에 있는 모든 플레이어를 가져옴
        playerList.AddRange(players); // 플레이어 리스트에 추가
    }

    public void PlayerListClose()
    {
        parentObj.transform.parent.gameObject.SetActive(false);
    }
}