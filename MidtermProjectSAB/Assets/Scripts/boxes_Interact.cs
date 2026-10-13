using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class boxes_Interact : MonoBehaviour
{
    // Check collision of sphere collider to enable interaction
    // Destroy boxes once you "got" the items
    // Call the Dialog Runner to initiate a node for interaction
    // When we collide prompt the player to interact with the boxes
    // Load the NPC_Interact class to activate the next phase of the 'quest'

    public bool canInteract;
    public TextMeshProUGUI interactText;
    public NPC_Data npcData;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            setText("Press E");
            canInteract = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            setText("");
            canInteract = false;
        }
    }

    public void setText(string txt)
    {
        interactText.text = txt;
    }

    public void Update()
    {
        if(canInteract)
        {
            if(Keyboard.current.eKey.wasPressedThisFrame)
                {
                    npcData.currentPhase = NPC_Data.dialogPhase.quest_complete;
                    canInteract = false;
                    Destroy(gameObject);
                    setText("");
                }
        }
    }
}
//     <<cam_move NPC_Cam_Rig "npc">>
// <<if $visitedYet == false>>
// //<<set $visitedYet to true>>
// Erling Haaland: Joost Klein is that you!
// Erling Haaland: I'm gonna take him off your hands.
// Erling Haaland: Thank you stranger.
// <<cam_move NPC_Cam_Rig "pc">>
//     -> ...Okay.
//         <<cam_move NPC_Cam_Rig "return">>
// <<dialogPhaseGetter NPC "quest_complete_return">>
// <<endif>>
// 
