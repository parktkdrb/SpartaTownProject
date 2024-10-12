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
        // Instantiate로 생성한 객체의 참조를 변수에 저장
        playerInstance = Instantiate(playerPrefab);
        playernameCanvasInstance = Instantiate(playernameCanvasPrefab);

        // 플레이어 이름 설정
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


        // 1. playerSp sprite와 GameManger sprite 이름 비교
        // 2. 다르면 playerObjList의 오브젝트를 순차적으로 돌면서
        // 3. playerInstane 파괴 후 하위 스프라이트 이름과 같으면 생성
        // 4. 무조건 있으니까 예외처리 안함.
        if (playerSp.sprite.name != GameManager.Instance.spritename)
        {
            // 기존의 이름 캔버스와 플레이어 인스턴스를 파괴
            Destroy(playerInstance);

            // 오브젝트 리스트 순회
            foreach (GameObject item in playerObjList)
            {
                // item의 스프라이트 이름 가져오기
                Sprite sp = item.GetComponentInChildren<SpriteRenderer>().sprite;

                // 이름이 GameManager에 저장된 스프라이트 이름과 같은지 비교
                if (sp.name == GameManager.Instance.spritename)
                {
                    // 새로운 플레이어 인스턴스 생성
                    playerInstance = Instantiate(item);
                    playerSp = playerInstance.GetComponentInChildren<SpriteRenderer>(); // playerSp 재할당
                    break; // 일치하는 오브젝트를 찾았으므로 루프 종료
                }
            }
        }
    }
}
