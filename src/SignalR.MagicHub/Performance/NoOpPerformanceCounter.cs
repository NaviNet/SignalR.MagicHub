﻿using System.Diagnostics;

namespace SignalR.MagicHub.Performance
{
    internal class NoOpPerformanceCounter : IPerformanceCounter
    {
        public string CounterName
        {
            get
            {
                return GetType().Name;
            }
        }

        public long Decrement()
        {
            return 0;
        }

        public long Increment()
        {
            return 0;
        }

        public long IncrementBy(long value)
        {
            return 0;
        }

        public long RawValue
        {
            get { return 0; }
            set { }
        }

        public void Close()
        {

        }

        public void RemoveInstance()
        {

        }

        public CounterSample NextSample()
        {
            return CounterSample.Empty;
        }
    }
}