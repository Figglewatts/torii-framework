using System;
using UnityEngine;

namespace Torii.Console
{
    public class ConsoleOpener : MonoBehaviour
    {
        public const KeyCode ConsoleKey = KeyCode.BackQuote;
        public UIDevConsole Console;

        public void Awake() { Application.logMessageReceived += Console.LogHandler; }

        public void Update()
        {
            if (Input.GetKeyDown(ConsoleKey))
            {
                Console.ToggleVisible();
            }
        }
    }
}
