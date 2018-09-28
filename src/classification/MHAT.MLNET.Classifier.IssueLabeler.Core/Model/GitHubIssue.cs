using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHAT.MLNET.Classifier.IssueLabeler.Core.Model
{
    public class GitHubIssue
    {
        [Column(ordinal: "0")]
        public string ID;

        [Column(ordinal: "1")]
        public string Area;

        [Column(ordinal: "2")]
        public string Title;

        [Column(ordinal: "3")]
        public string Description;
    }
}
