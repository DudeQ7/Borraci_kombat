using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float sprintMultiplier = 2f;
    public float fallLimit = -5f;

    public TextMeshProUGUI respawnText;
    public float messageDuration = 3f;

    public AudioSource footstepsAudio;

    private Vector3 startPosition;
    private Rigidbody rb;
    private Coroutine messageCoroutine;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        if (respawnText != null)
            respawnText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;
        float height = 0f;
        if (Input.GetKey(KeyCode.A))
            horizontal = -1f;
        if (Input.GetKey(KeyCode.D))
            horizontal = 1f;
        if (Input.GetKey(KeyCode.W))
            vertical = 1f;
        if (Input.GetKey(KeyCode.S))
            vertical = -1f;

        float currentSpeed = speed;
        Vector3 movement = new Vector3(horizontal, height, vertical);
        transform.Translate(movement.normalized * currentSpeed * Time.deltaTime, Space.World);

        if (footstepsAudio != null)
        {
            if (movement.magnitude > 0f)
            {
                if (!footstepsAudio.isPlaying)
                    footstepsAudio.Play();
            }
            else
            {
                if (footstepsAudio.isPlaying)
                    footstepsAudio.Stop();
            }
        }

        if (transform.position.y < fallLimit)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.position = startPosition;
        }
        else
        {
            transform.position = startPosition;
        }

        if (footstepsAudio != null)
            footstepsAudio.Stop();

        if (respawnText != null)
        {
            if (messageCoroutine != null)
                StopCoroutine(messageCoroutine);
            messageCoroutine = StartCoroutine(ShowRespawnMessage());
        }
        Debug.Log("Respawn! Powrot na start!");
    }
    IEnumerator ShowRespawnMessage()
    {
        respawnText.gameObject.SetActive(true);

        yield return new WaitForSeconds(messageDuration);

        respawnText.gameObject.SetActive(false);
        messageCoroutine = null;
    }
}