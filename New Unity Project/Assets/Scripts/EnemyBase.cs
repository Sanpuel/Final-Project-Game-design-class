using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/Create new Enemy")]
public class EnemyBase : ScriptableObject
{
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite EnemySprite;

    // Base Stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
