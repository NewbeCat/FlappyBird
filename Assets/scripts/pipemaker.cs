using UnityEngine;
using TMPro;

public class pipemaker : MonoBehaviour
{
    public GameObject pipeset;
    public float nowTime;
    public float makeTime = 2f;
    public TextMeshProUGUI ScoreUI;
    private int score = 0;
    private float scoreTime;
    private AudioSource audioSource;
    public AudioClip point;

    void Start()
    {
        nowTime = Time.time;
        scoreTime = Time.time + 3f;
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = point;
    }

    void Update()
    {
        if (Time.time - nowTime > makeTime)
        {
            nowTime = Time.time;
            GameObject temp = Instantiate(pipeset);
            temp.transform.parent = gameObject.transform;
            float randomY = Random.Range(-3.3f, 1.3f);
            temp.transform.localPosition = new Vector3(-gameObject.transform.localPosition.x + 5, randomY, 0);
            temp.transform.localScale = Vector3.one;
        }

        if (Time.time - scoreTime > 2f)
        {
            scoreTime = Time.time;
            score++;
            ScoreUI.text = score.ToString();
            audioSource.PlayOneShot(point);
        }
    }
}