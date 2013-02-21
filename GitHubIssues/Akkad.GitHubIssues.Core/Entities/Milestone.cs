using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkad.GitHubIssues.Core.Entities
{
    public class Milestone
    {
        public string url { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Creator creator { get; set; }
        public int open_issues { get; set; }
        public int closed_issues { get; set; }
        public string created_at { get; set; }
        public object due_on { get; set; }
    }   
}
