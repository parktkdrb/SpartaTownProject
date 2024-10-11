using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PositionManager : MonoBehaviour
{
    [SerializeField] private GameObject camara;
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerManager playermanager;
    // Start is called before the first frame update

    private void Start()
    {
        playermanager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        player = playermanager.playerInstance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {/* 카메라 부드럽게 움직이기(카메라랑 player랑 동시에 움직이면 화면이 떨려보임)
        Vector3 targetPosition = player.transform.position;
        targetPosition.z = camara.transform.position.z;
        camara.transform.position = Vector3.Lerp(camara.transform.position, targetPosition, Time.deltaTime * cameraMoveSpeed);
      */
        Vector3 playerpos = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        camara.transform.position = playerpos;
    }
}
