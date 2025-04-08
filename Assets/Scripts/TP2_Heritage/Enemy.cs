using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int damage;
    [SerializeField] private float speed;
    [SerializeField] private float detectionRange;
    [SerializeField] private int giveXP;
    [SerializeField] private Transform player;
    [SerializeField] protected PlayerCharacterGood playerChara;

    #region Capsulation
    public int Health { get => health; set => health = value; }
    public int Damage { get => damage; set => damage = value; }
    public float Speed { get => speed; set => speed = value; }
    public float DetectionRange { get => detectionRange; set => detectionRange = value; }
    public Transform Player { get => player; set => player = value; }
    public PlayerCharacterGood PlayerChara { get => playerChara; set => playerChara = value; }
    public int GiveXP { get => giveXP; set => giveXP = value; }
    #endregion

    protected virtual void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < DetectionRange)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }

    protected virtual void Start()
    {
        PlayerChara = GameObject.Find("Player").GetComponent<PlayerCharacterGood>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
