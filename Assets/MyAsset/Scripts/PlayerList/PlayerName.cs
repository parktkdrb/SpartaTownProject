using UnityEngine;
[System.Serializable]
public class PlayerName
{
    public string playername { get; set; }

    public PlayerName(string _playername)
    {
        playername = _playername; // 플레이어 초기화
    }
}