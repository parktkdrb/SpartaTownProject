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
        // Instantiate로 생성한 객체의 참조를 변수에 저장
        playerInstance = Instantiate(playerPrefab);
        playernameCanvasInstance = Instantiate(playernameCanvasPrefab);

        // 플레이어 이름 설정
        playerInstance.name = GameManager.Instance.name;
        SpriteRenderer playersp = playerInstance.GetComponentInChildren<SpriteRenderer>();
        playerNameText = playernameCanvasInstance.GetComponentInChildren<TextMeshProUGUI>();

    }
    private void FixedUpdate()
    {// GameManager의 name 값이 변경되었을 때 UI를 갱신합니다.
        if (playerNameText.text != GameManager.Instance.name || playerInstance.name != GameManager.Instance.name)
        {
            Debug.Log("이름 변경");
            playerNameText.text = GameManager.Instance.name;
            playerInstance.name = GameManager.Instance.name;
        }

        playernameCanvasInstance.transform.position = playerInstance.transform.position + new Vector3(0, 0.5f, 0);
    }
}
