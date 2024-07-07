using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class QuizAPIClient
{
    private static readonly HttpClient client = new HttpClient();
    private const string apiKey = "ilpKZC6xH6wMskLy3vveEVbpVxIXeH95QhRIJO6O";

    public async Task<List<Question>> GetQuestions(int limit = 15, string category = "")
    {
        string query;
        if(category.Equals("")) query = $"https://quizapi.io/api/v1/questions?apiKey={apiKey}&limit={limit}";
        else query = $"https://quizapi.io/api/v1/questions?apiKey={apiKey}&limit={limit}&category={category}";

        try
        {
            var response = await client.GetAsync(query);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var questions = JsonConvert.DeserializeObject<List<Question>>(jsonResponse);
                return questions;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {response.StatusCode} - {errorResponse}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Request failed: {ex.Message}");
        }
    }
}

public class Question
{
    public string question { get; set; }
    public Dictionary<string, string> answers { get; set; }
    public Dictionary<string, string> correct_answers { get; set; }
    public string correct_answer { get; set; }

    public bool multiple_correct_answers;
    public List<String> QuestionsSelectedByUser { get; set; }

    public Question()
    {
        QuestionsSelectedByUser = new List<string>();
    }

    public List<string> GetCorrectAnswers()
    {
        List<string> correctAnswers = new List<string>();
        foreach(KeyValuePair<string, string> pair in correct_answers)
        {
            if (pair.Value.Equals("true"))
            {
                correctAnswers.Add(answers[pair.Key.Substring(0,8)]);
            }
        }
        return correctAnswers;
    }

    public void SaveSelectedAnswers(List<string> selectedAnswers)
    {
        QuestionsSelectedByUser = selectedAnswers;
    }
}

/// <summary>
/// Displays the current question and its possible answers on the form.
/// </summary>


