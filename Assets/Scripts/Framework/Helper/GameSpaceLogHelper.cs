using GameFrameX;
using UnityEngine;

namespace GameSpace.Helper
{
    public class GameSpaceLogHelper : GameFrameworkLog.ILogHelper
    {
        private const string LogDebugColor = "<color=#9DEB58>{0}</color>";
        private const string LogInfoColor = "<color=#FBF8ED>{0}</color>";
        private const string LogWarningColor = "<color=#F2C55C>{0}</color>";
        private const string LogErrorColor = "<color=#DB5C5C>{0}</color>";
        
        public void Log(GameFrameworkLogLevel level, object message)
        {
            switch (level)
            {
                case GameFrameworkLogLevel.Debug:
                    Debug.Log(Utility.Text.Format(LogDebugColor, $" --- {message}"));
                    break;
                case GameFrameworkLogLevel.Info:
                    Debug.Log(Utility.Text.Format(LogInfoColor, $" ------ {message} ------ "));
                    break;
                case GameFrameworkLogLevel.Warning:
                    Debug.LogWarning(Utility.Text.Format(LogWarningColor, message.ToString()));
                    break;
                case GameFrameworkLogLevel.Error:
                    Debug.LogError(Utility.Text.Format(LogErrorColor, $" ------ {message} ------ "));
                    break;
                default:
                    throw new GameFrameworkException(message.ToString());
            }
        }
    }
}