using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Models
{
    public class Tag
    {
        public string id;
        public string tagName;
        public Tag(string id, string tagName)
        {
            this.id = id;
            this.tagName = tagName;
        }
    }
}