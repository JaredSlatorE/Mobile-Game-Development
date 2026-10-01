using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SMultiplayerCamera : MonoBehaviour
{
    public PlayerInputManager inputManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<GameObject> players = new List<GameObject>();
    

    void Start() //Add player join event
    {
        inputManager.onPlayerJoined += playerJoined;
    }
    void Update() //Run every frame
    {
        gameObject.transform.position = newCameraPosition();
    }

    public void playerJoined(PlayerInput playerInput)
    {
        players.Add(playerInput.gameObject); //Add player to players list
    }



    public Vector2 newCameraPosition()
    {
        Vector2 returnTransform = players[0].transform.position;
        for(int i = 0; i < players.Count - 1; i++)
        {
            if (i == 0) //Only get position between players
            {
                returnTransform = Vector2.Lerp(players[i].transform.position,players[i+1].transform.position,0.5f);
            }
            else if (i < 0) //Not optimal players, code never runs
            {
                return players[i].transform.position;
            }
            else //Get distance between the calculated point and the new player
            {
                returnTransform = Vector2.Lerp(returnTransform,players[i+1].transform.position,0.5f);
            }
        }

        return returnTransform;
    }
}
