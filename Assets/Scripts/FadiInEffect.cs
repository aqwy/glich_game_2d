using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadiInEffect : MonoBehaviour
{
    public float fadeinTime = 2.5f;

    private Image _currentImg;
    private Color _currentColor;
    private float _alfaChanging;
    void Start()
    {
        _currentColor = Color.black;
        _currentImg = GetComponent<Image>();
    }
    void Update()
    {
        if (Time.timeSinceLevelLoad < fadeinTime)
        {
            _alfaChanging = Time.deltaTime / fadeinTime;
            _currentColor.a -= _alfaChanging;
            _currentImg.color = _currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
