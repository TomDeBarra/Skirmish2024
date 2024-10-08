using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rs_TestInstanceScript : MonoBehaviour
{
    float timer = 0;
    bool isFlashing = false;
    float flashFrequency;
    TMPro.TextMeshPro m_TextMeshPro;

    internal void AttachTo(Transform transformToAttachTo)
    {
        m_TextMeshPro.alignment = TMPro.TextAlignmentOptions.Center;
        m_TextMeshPro.rectTransform.pivot = new Vector2(0.5f, 0);
        transform.parent = transformToAttachTo;
    }

    internal void initialize(string newText)
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();
        m_TextMeshPro.text = newText;
        m_TextMeshPro.rectTransform.anchoredPosition = Vector3.zero;
    }

    internal void SetText(string newText)
    {
        m_TextMeshPro.text = newText;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_TextMeshPro = GetComponent<TMPro.TextMeshPro>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlashing)
        {
            timer += Time.deltaTime;
            m_TextMeshPro.alpha = Mathf.Pow(Mathf.Cos(timer*flashFrequency * Mathf.PI), 2);


        }


        transform.LookAt(2 * transform.position - Camera.main.transform.position);
    }

    private void positionOverParent()
    {
        throw new NotImplementedException();
    }

    internal void SetColor(Color newColor)
    {

        m_TextMeshPro.color = newColor;
    }

    internal void SetPosition(Vector2 vector2)
    {
      

    }

    internal void StartFlash(float frequencyOfFlash)
    {
        flashFrequency = frequencyOfFlash;
        m_TextMeshPro.alpha = 1.0f;
        timer = 0;
        isFlashing = true;
    }
}
