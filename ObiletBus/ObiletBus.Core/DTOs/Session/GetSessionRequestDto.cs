using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletBus.Core.DTOs.Session
{
    public class GetSessionRequestDto
    {
        public int type { get; set; }
        public ConnectionDto connection { get; set; }
        public BrowserDto browser { get; set; }
        public ApplicationDto application { get; set; }
    }
}
