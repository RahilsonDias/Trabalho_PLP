using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Dialog dialogue;
    public int activatingDialogue;

    public GameObject tochaAndar;
    public GameObject tochaPular;

    public SpriteRenderer spriteAndar;
    public SpriteRenderer spritePular;

    private void OnEnable()
    {
        Subscribe();
    }
    private void OnDisable()
    {
        Unsubscribe();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.currentDialog == activatingDialogue)
        {
            tochaPular.SetActive(true);
            tochaAndar.SetActive(true);
        }
        else
        {
            tochaPular.SetActive(false);
            tochaAndar.SetActive(false);
        }
    }

    public void Subscribe()
    {
        PlayerMovement.OnPlayerJump += PlayerMovement_OnPlayerJump;
        PlayerMovement.OnPlayerWalk += PlayerMovement_OnPlayerWalk;
    }

    public void Unsubscribe()
    {
        PlayerMovement.OnPlayerJump -= PlayerMovement_OnPlayerJump;
        PlayerMovement.OnPlayerWalk -= PlayerMovement_OnPlayerWalk;
    }

    private void PlayerMovement_OnPlayerJump(bool isWalking)
    {
        if (isWalking)
            spritePular.enabled = true;
        else
            spritePular.enabled = false;
    }

    private void PlayerMovement_OnPlayerWalk(bool isWalking)
    {
        if (isWalking)
            spriteAndar.enabled = true;
        else
            spriteAndar.enabled = false;
    }
}
