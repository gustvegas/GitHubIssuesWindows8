﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkad.GitHubIssues.Core.Entities
{
    public class Notify
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public User user { get; set; }
        public List<Label> labels { get; set; }
        public Assignee assignee { get; set; }
        public Milestone milestone { get; set; }
        public int comments { get; set; }
        public PullRequest pull_request { get; set; }
        public object closed_at { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
