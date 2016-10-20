using System;
using Android.Runtime;
using Com.Google.Android.Exoplayer.Drm;

namespace Com.Google.Android.Exoplayer.Drm
{
    public partial interface IExoMediaDrmOnEventListener
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/interface[@name='ExoMediaDrm.OnEventListener']/method[@name='onEvent' and count(parameter)=5 and parameter[1][@type='com.google.android.exoplayer.drm.ExoMediaDrm&lt;? extends T&gt;'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
        //[Register("onEvent", "(Lcom/google/android/exoplayer/drm/ExoMediaDrm;[BII[B)V", "GetOnEvent_Lcom_google_android_exoplayer_drm_ExoMediaDrm_arrayBIIarrayBHandler:Com.Google.Android.Exoplayer.Drm.IExoMediaDrmOnEventListenerInvoker, ExoPlayer")]
        //void OnEvent(global::Com.Google.Android.Exoplayer.Drm.IExoMediaDrm p0, byte[] p1, int p2, int p3, byte[] p4);
    }

    public interface IExoMediaDrmOnEventListener<ExoMediaCrypto> : IExoMediaDrmOnEventListener
    {
        
    }
}
