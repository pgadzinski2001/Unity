using UnityEngine;

public class koszenie : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue,0,zValue);
    }
}
