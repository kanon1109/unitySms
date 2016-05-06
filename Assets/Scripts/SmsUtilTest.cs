using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SmsUtilTest : MonoBehaviour
{
    public InputField numberText;
    public InputField contentText;
    public Button sendBtn;
    public Button openBtn;
    // Use this for initialization
    void Start()
    {
        this.sendBtn.onClick.AddListener(sendBtnClickHandler);
        this.openBtn.onClick.AddListener(openBtnClickHandler);
    }

    private void openBtnClickHandler()
    {
        if (this.numberText.text == "" ||
            this.contentText.text == "") return;
        SmsUtil.openSms(this.numberText.text, this.contentText.text);
    }

    private void sendBtnClickHandler()
    {
        if (this.numberText.text == "" || 
            this.contentText.text == "") return;
        SmsUtil.smsSend(this.numberText.text, this.contentText.text);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
