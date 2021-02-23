using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkController : MonoBehaviour
{
    private Animator _eyeAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        _eyeAnimator = GetComponent<Animator>();
        StartCoroutine(IEBlink());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator IEBlink()
    {
        float timer = Random.Range(4f,6f);
        yield return new WaitForSeconds(timer);
        _eyeAnimator.Play("Blink", 0, 0f);
        StartCoroutine(IEBlink());
    }
}
