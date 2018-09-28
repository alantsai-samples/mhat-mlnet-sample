using MHAT.MLNET.Classifier.IssueLabeler.Core.Model;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHAT.MLNET.Classifier.IssueLabeler.WinForm
{
    public partial class Form1 : Form
    {
        private static PredictionModel<GitHubIssue, GithubIssueLabelPrediction> Model;
        private static string ModelPath;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPredic_Click(object sender, EventArgs e)
        {
            lblPredict.Text = "<Issue預測Label>";

            var issue = new GitHubIssue()
            {
                Title = txtTitle.Text,
                Description = rtxtboxDescription.Text
            };

            if(Model == null || ModelPath != txtModelPath.Text)
            {
                ModelPath = txtModelPath.Text;

                Model = await PredictionModel.ReadAsync
                    <GitHubIssue, GithubIssueLabelPrediction>(ModelPath);
            }

            lblPredict.Text = Model.Predict(issue).Area;
        }
    }
}
