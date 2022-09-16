using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public class TagService : ITagService
    {
        public List<string> Get()
        {
            return new() { "C#", ".Net", "Angular" };
        }
    }
}
