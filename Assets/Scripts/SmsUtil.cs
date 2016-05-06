using UnityEngine;
using System.Collections;
/// <summary>
/// 短信工具
/// </summary>
public class SmsUtil
{
    //安卓类
#if UNITY_ANDROID
    private static AndroidJavaClass ajc = null;
#endif

    /// <summary>
    /// 发送短信
    /// </summary>
    /// <param name="number">号码</param>
    /// <param name="content">内容</param>
    public static void smsSend(string number, string content)
    {
#if UNITY_ANDROID
        if (ajc == null)
            ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
        ajo.Call("smsSend", new string[] { number, content });
#elif UNITY_IPHONE
        //TODO
#endif
    }
    
    /// <summary>
    /// 打开短信
    /// </summary>
    /// <param name="number">号码</param>
    /// <param name="content">内容</param>
    public static void openSms(string number, string content)
    {
#if UNITY_ANDROID
        if (ajc == null)
            ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
        ajo.Call("openSms", new string[] { number, content });
#elif UNITY_IPHONE
        //TODO
#endif
    }
}
