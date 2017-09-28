using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float scaleSpeed = 1.0f;
    public float rotateSpeed = 1.0f;
    private float time = 0.0f;
    double m_angle = 0.0f;
    Transform m_transform;
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }
    private void Update()
    {
        m_angle += rotateSpeed;
        time += Time.deltaTime * scaleSpeed;
        m_transform.position = new Vector3(m_transform.position.x + moveSpeed * Time.deltaTime, 
            m_transform.position.y, m_transform.position.z);
        float scale = Mathf.Sin(time);
        m_transform.localScale =  new Vector3(scale, scale, scale);
        m_transform.rotation = Quaternion.Euler((float)m_angle, 0.0f, 0.0f);
    }
}
