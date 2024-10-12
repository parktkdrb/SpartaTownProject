using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PositionManager : MonoBehaviour
{
    [SerializeField] public GameObject camara;
    [SerializeField] public GameObject player;
    [SerializeField] private PlayerManager playerManager;
    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 playerpos = new Vector3(playerManager.playerInstance.transform.position.x, playerManager.playerInstance.transform.position.y, -10);
        camara.transform.position = playerpos;

       playerManager.playernameCanvasInstance.transform.position = playerManager.playerInstance.transform.position + new Vector3(0, 0.5f, 0);
    }
}
