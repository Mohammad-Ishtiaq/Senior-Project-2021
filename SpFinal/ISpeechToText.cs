using System;
using System.Collections.Generic;
using System.Text;

namespace SpFinal
{
    /// <summary>
    /// this is a interface create for get option for speech from ios and android if is
    /// runing on ios its used ios SDK for speech to text and if is runing on android 
    /// its used android SDK for this purpose
    /// </summary>
    public interface ISpeechToText
    {
        /// <summary>
        /// This is method for Start Speech To Text
        /// </summary>
        void StartSpeechToText();
        /// <summary>
        /// this is method is used for Stop Speech To Text
        /// </summary>
        void StopSpeechToText();
    }
}
