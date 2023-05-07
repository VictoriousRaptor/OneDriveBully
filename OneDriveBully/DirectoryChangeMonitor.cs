// Adapted from Flow
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OneDriveBully
{
    public class DirectoryChangeMonitor : IDisposable
    {
        private readonly List<FileSystemWatcher> Watchers = new List<FileSystemWatcher>();
        private readonly Channel<byte> indexQueue = Channel.CreateBounded<byte>(1);
        private readonly SemaphoreSlim semaphore = new (1, 1);

        public void WatchDirs(IEnumerable<string> paths)
        {
            ClearWatchers();
            foreach (var directory in from path in paths where Directory.Exists(path) select path)
            {
                WatchDirectory(directory);
            }

            _ = Task.Run(BullyOnDirChange);
        }

        public async Task BullyOnDirChange()
        {
            if (semaphore.CurrentCount == 0 || Watchers.Count == 0)
            {
                return;
            }
            semaphore.Wait();
            var reader = indexQueue.Reader;
            while (await reader.WaitToReadAsync())
            {
                await Task.Delay(500);
                while (reader.TryRead(out _))
                {
                }
                await Task.Run(ProcessIcon.fn.bullyNow);
            }
            semaphore.Release();
        }

        private void WatchDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new ArgumentException("Path Not Exist");
            }
            var watcher = new FileSystemWatcher(directory);

            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.NotifyFilter = NotifyFilters.FileName |
                                   NotifyFilters.LastWrite |
                                   NotifyFilters.DirectoryName |
                                   NotifyFilters.Size |
                                   NotifyFilters.Attributes;

            watcher.Created += (_, _) => indexQueue.Writer.TryWrite(default);
            watcher.Deleted += (_, _) => indexQueue.Writer.TryWrite(default);
            watcher.Renamed += (_, _) => indexQueue.Writer.TryWrite(default);
            watcher.Changed += (_, _) => indexQueue.Writer.TryWrite(default);
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;

            Watchers.Add(watcher);
        }

        public void Dispose()
        {
            ClearWatchers();
        }

        private void ClearWatchers()
        {
            foreach (var fileSystemWatcher in Watchers)
            {
                fileSystemWatcher.Dispose();
            }
            Watchers.Clear();
        }
    }
}
