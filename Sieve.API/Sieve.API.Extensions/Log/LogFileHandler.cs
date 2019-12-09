using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sieve.API.Extensions.Log
{
    public class LogFileHandler
    {
        public List<string> Queue { get; private set; }
        private const string PATH = "logs\\";
        public string LogFile = "";
        private bool isBusy = false;

        public LogFileHandler()
        {
            Queue = new List<string>();
        }

        public async Task Initialize()
        {
            if (!Directory.Exists(PATH))
                Directory.CreateDirectory(PATH);
            if (string.IsNullOrEmpty(LogFile))
                LogFile = GetFile();
            if (!File.Exists(LogFile))
            {
                await File.WriteAllTextAsync(LogFile, "");
                File.SetAttributes(LogFile, FileAttributes.Normal);
            }
            await Task.Delay(100);
        }

        private string GetFile()
        {
            return $"{PATH}log {DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss tt")}.txt";
        }

        public void Enqueue(string logMessage)
        {
            Queue.Add(logMessage);
        }

        public async Task Run(CancellationToken ct = default)
        {
            while (isBusy)
                await Task.Delay(100);
            isBusy = true;
            try
            {
                await File.AppendAllTextAsync(LogFile, Queue.First().Replace("\n", System.Environment.NewLine), System.Text.Encoding.Unicode, ct);
                Queue.RemoveAt(0);
                isBusy = false;
            }
            catch
            {
                isBusy = false;
                await Run(ct);
            }
        }
    }
}
