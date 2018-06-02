using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace UniqueExcelConsole
{
    partial class AIActionPane : UserControl
    {
        public AIActionPane()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Send_Click(object sender, EventArgs e)
        {
            //发送消息

            Thread th = new Thread(SendAIMsg);
            th.IsBackground = true;
            th.Start();

        }

        void SendAIMsg()
        {
            var client = new RestClient("https://westus.api.cognitive.microsoft.com/qnamaker/v2.0/knowledgebases/8f9e4e52-b814-407a-9a6a-b7a84e2be69d/generateAnswer");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Ocp-Apim-Subscription-Key", "e920fbfd67074beb97e52abf4aef4dc3");
            request.AddHeader("Content-Type", "application/json");
            string s = ("{\"question\":\"" + this.Question.Text + "\"}");


            request.AddParameter("undefined", s, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            QnAMakerResult Ansresponse;
            try
            {
                Ansresponse = JsonConvert.DeserializeObject<QnAMakerResult>(response.Content);
                AnsBox.Text = Ansresponse.Answers[0].AnswerAnswer;
                
            }
            catch
            {
                throw new Exception("Unable to deserialize QnA Maker response string.");
            }
            
        }

       
    }


    public class QnAMakerResult
    {
        [JsonProperty("answers")]
        public Answer[] Answers { get; set; }
    }

    public class Answer
    {
        [JsonProperty("answer")]
        public string AnswerAnswer { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }
}


