using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adaptador : MonoBehaviour
{
    public GameObject[] enemies;
    public int delay;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("HostileEntity");
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= delay)
        {
            Command();
            count = 0;
            
        }
    }

    private void Command()
    {
        foreach (var item in enemies)
        {
            if(item.TryGetComponent(out IEnemy enemy))
            {
                enemy.Attack();
                print("command");
            }
        }
    }
}
