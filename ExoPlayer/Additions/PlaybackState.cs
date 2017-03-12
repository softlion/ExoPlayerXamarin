using Android.Runtime;

namespace Com.Google.Android.Exoplayer2
{
    /// <summary>
    /// http://google.github.io/ExoPlayer/doc/reference-v1/com/google/android/exoplayer/ExoPlayer.html#State
    /// </summary>
    [Preserve]
    public enum PlaybackState
    {
        //TrackDisabled = -1,
        //UnknownTime = -1,
        //TrackDefault = 0,
        Idle = ExoPlayer.StateIdle,
        //Preparing = 2,
        Buffering = ExoPlayer.StateBuffering,
        Ready = ExoPlayer.StateReady,
        Ended = ExoPlayer.StateEnded,
    }
}
