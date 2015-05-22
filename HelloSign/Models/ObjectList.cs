using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Generic base class for a list of objects from the API.
    /// </summary>
    public class ObjectList<T> : IEnumerable<T>
    {
        public int? NumPages { get; set; }
        public int? NumResults { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public List<T> Items { get; set; }
        
        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
