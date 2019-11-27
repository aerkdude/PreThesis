using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public GameObject everything;
    public GameObject gameOverImage;
    public GameObject chaseBGM;
    private Transform Target;

    [SerializeField] private AudioSource screamSound;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            screamSound.Play();
            everything.SetActive(false);
            gameOverImage.SetActive(true);
            chaseBGM.SetActive(false);
            Debug.Log("Game Over");
        }
    }
}
