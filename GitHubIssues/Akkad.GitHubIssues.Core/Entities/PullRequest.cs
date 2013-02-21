using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkad.GitHubIssues.Core.Entities
{
    public class PullRequest
    {
        public string html_url { get; set; }
        public string diff_url { get; set; }
        public string patch_url { get; set; }
    }
}
