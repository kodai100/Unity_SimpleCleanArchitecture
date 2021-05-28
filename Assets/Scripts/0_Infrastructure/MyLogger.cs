using UnityEngine;

namespace kodai100.CA.Infrastructure
{
    public static class MyLogger
    {

        private const string AuthorName = "kodai100";

        public static void Log(string message)
        {
            Debug.Log($"### {AuthorName} ### - {message}");
        }
        
        public static void Error(string message)
        {
            Debug.LogError($"### {AuthorName} ### - {message}");
        }
        
        public static void Warn(string message)
        {
            Debug.LogWarning($"### {AuthorName} ### - {message}");
        }
        
    }

}