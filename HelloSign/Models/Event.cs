using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Event.
    /// </summary>
    public class Event<T>
    {
        public int? EventTime { get; set; }
        public string EventType { get; set; }
        public string EventHash { get; set; }
        public Dictionary<string, string> EventMetadata { get; set; }
        public T Item { get; set; }
    }
}
