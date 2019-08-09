using System.Collections.Generic;

namespace VidzyCodeFirst
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Videos { get; set; }
    }
}
