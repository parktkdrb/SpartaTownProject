using System.Collections.Generic;
using UnityEngine;

public class PlayerListManager : MonoBehaviour
{
    public List<PlayerName> players = new List<PlayerName>();

    // 플레이어 추가
    public void AddPlayer(string playername)
    {
        players.Add(new PlayerName(playername));
    }

    // 특정 플레이어 이름 변경
    public void ChangePlayerName(int index, string newName)
    {
        if (index >= 0 && index < players.Count)
        {
            players[index].playername = newName;
        }
    }

    // 모든 플레이어 이름 출력 (디버깅용)
    public void PrintAllPlayerNames()
    {
        foreach (var player in players)
        {
            Debug.Log(player.playername);
        }
    }
}