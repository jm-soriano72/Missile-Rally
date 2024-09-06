using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numPlayers = 4;

    public RaceController currentRace;

    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}