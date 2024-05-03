using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class KrisInfoResponse
    {
        public int Identifier { get; set; }
        public string PushMessage { get; set; }
        public DateTime Published { get; set; }
        public List<Area> Area { get; set; }
        public List<Links> Links { get; set; }
        public string BodyText { get; set; }
        public string Headline { get; set; }
        public DateTime Updated { get; set; }
    }
}
