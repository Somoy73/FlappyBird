using UnityEngine;
using UnityEngine.UI;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    public float gap = 3f;
    
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;
    }

    private void Update()
    {
        
        int score = GameManager.Instance.score;
        if (score > 100)
        {
            speed = 6f;
        }
        else if (score > 200)
        {
            speed = 6.5f;
        }
        else if (score > 300)
        {
            speed = 7f;
        }
        else if (score > 400)
        {
            speed = 8f;
        }
        
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }

}
