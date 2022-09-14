using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private PlayerController player;
    public static PlayerController Player;

    public static float timeLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
