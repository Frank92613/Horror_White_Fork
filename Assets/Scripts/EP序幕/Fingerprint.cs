using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fingerprint: MonoBehaviour
{
    public Animator BlinkAnim;
    public GameObject officerState; //�x��
    public GameObject secondTitle;//�ĤG�Ӽ��D

    public Animator paperUpAnim;
    public float MurMurTime = 10f;
    public static bool getFingerPrint = false; //�\��L�P�_ 

    public GameObject RedFinger;


    //private bool isCoroutineRunning = false;
    public float doBlink = 3f;
    void Start()
    {

    }


    void Update()
    {
        //��k�G - ��(�C���@�g���ʫ�Ĳ�o������ getFingerPrint = true)
        StartCoroutine(BlinkAndDisappear());


        /*��k�@
        Invoke("BlinkEye", doBlink);
        Invoke("officerDisappear", doBlink+3.0f);*/
        Debug.Log("state:" + getFingerPrint);
    }

    private IEnumerator BlinkAndDisappear()
    {
        yield return new WaitForSeconds(MurMurTime);
        paperUpAnim.SetBool("Up", true);

        yield return new WaitForSeconds(MurMurTime + 1f);
        RedFinger.SetActive(true);

        if (getFingerPrint) { 
        yield return new WaitForSeconds(doBlink);
        BlinkAnim.SetBool("Blink", true); // 'doBlink'���A�w��

        yield return new WaitForSeconds(1f);
        officerState.SetActive(false);
        secondTitle.SetActive(true);
        }
        

    }

    /*public void BlinkEye()
    {
        BlinkAnim.SetBool("Blink", true); //����
    }
    public void officerDisappear(){
        officerState.SetActive(false); //�ʨc����
    }*/

}
