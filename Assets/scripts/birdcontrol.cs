using UnityEngine;
using UnityEngine.SceneManagement;

public class birdcontrol : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip death;
    private AudioSource audioSource;

    void Start()
    {
        Screen.SetResolution(480, 800, false);
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            audioSource.PlayOneShot(jump);
            gameObject.GetComponent<Rigidbody>().AddForce(0, 500, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("flapp_scene");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        Time.timeScale = 0;
        audioSource.PlayOneShot(death);
        gameObject.GetComponent<Animator>().Play("Die");
    }
}
