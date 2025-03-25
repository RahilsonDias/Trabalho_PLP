using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public float rotSpeed;
    public Dialog dialogue;
    public int activatingDialogue;
    public string sceneToLoad;

    private SpriteRenderer sprite;
    private BoxCollider2D col;
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.currentDialog == activatingDialogue)
        {
            sprite.enabled = true;
            col.enabled = true;
        }
        else
        {
            sprite.enabled = false;
            col.enabled = false;
        }

        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
