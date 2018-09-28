using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHAT.MLNET.Classifier.IssueLabeler.Core.Model
{
    public class GithubIssueLabelPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Area;
    }
}
