using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;


namespace LoginDM
{
    public partial class PerguntaChatGPT : Form
    {
        //Inicio ChatGPT
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiUrl;

        public PerguntaChatGPT()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _apiKey = "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";
            _apiUrl = "https://api.openai.com/v1/engines/davinci-codex/completions";
        }

        private async Task<string> GetAnswer(string prompt)
        {
            var request = new HttpRequestMessage(new HttpMethod("POST"), _apiUrl);
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");

            var requestData = new
            {
                prompt,
                max_tokens = 50,
                n = 1,
                stop = "\n"
            };

            var json = JsonSerializer.Serialize(requestData);
            request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<OpenAIResult>(responseBody);
            var answer = result.choices[0].text;

            return answer;
        }

        private async void btnPergunta_Click_1(object sender, EventArgs e)
        {
            var question = txtPergunta.Text;
            var answer = await GetAnswer(question);
            txtResposta.Text = answer;
        }

        class OpenAIResult
        {
            public OpenAIChoice[] choices { get; set; }
        }

        class OpenAIChoice
        {
            public string text { get; set; }
        }
        //Fim ChatGPT



      

        private void PerguntaChatGPT_Load(object sender, EventArgs e)
        {

        }

      

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPergunta.Text = "";
            txtResposta.Text = "";
        }
    }
}
