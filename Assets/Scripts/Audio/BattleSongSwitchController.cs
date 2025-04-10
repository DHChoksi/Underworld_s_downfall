using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSongSwitchController : MonoBehaviour {
    private GameObject door;
    private GameObject battleDoor;
    public AudioSource srcMaze;
    public AudioSource srcNight;
    private AudioLoopController audioLoopControllerMaze;
    private AudioLoopController audioLoopControllerNight;
    public AudioSource srcSacrifice;
    private AudioLoopController audioLoopControllerSacrifice;
    // Set a variable to store the last played audio source
    public AudioSource lastPlayed;

    // Start is called before the first frame update
    void Start() {
        door = GetComponent<GameObject>();
        battleDoor = GameObject.FindWithTag("Interact");
        audioLoopControllerMaze = srcMaze.GetComponent<AudioLoopController>();
        audioLoopControllerNight = srcNight.GetComponent<AudioLoopController>();
        audioLoopControllerSacrifice = srcSacrifice.GetComponent<AudioLoopController>();
        lastPlayed = srcNight;
    }//end Start()

    // Update is called once per frame
    void Update() {
        // If Player clicks on the door // TODO: Make sure this will work with the player's mouse click
        if (door.tag == "Interact" && Input.GetMouseButtonDown(0)) {
            // Check if the last played audio source is the maze audio source
            if (lastPlayed == srcMaze) {
                // Stop the sacrifice audio source if it is playing
                audioLoopControllerSacrifice.play = false;
                // Stop the maze audio source
                audioLoopControllerMaze.play = false;
                // Play the night audio source
                audioLoopControllerNight.play = true;
                // Set the last played audio source to the night audio source
                lastPlayed = srcNight;
            } else {
                // Stop the sacrifice audio source if it is playing
                audioLoopControllerSacrifice.play = false;
                // Stop the night audio source
                audioLoopControllerNight.play = false;
                // Play the maze audio source
                audioLoopControllerMaze.play = true;
                // Set the last played audio source to the maze audio source
                lastPlayed = srcMaze;
            }//end if-else
        }//end if
    }//end Update()
}//end BattleSongSwitchController
