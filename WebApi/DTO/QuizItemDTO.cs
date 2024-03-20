using BackendLab01;

namespace WebApi.DTO;

public class QuizItemDTO
{
    private static Random rand = new Random();
    public int Id { get; set; }
    public string Question { get; set; }
    public List<string> Options { get; set; }
    public static QuizItemDTO Of(QuizItem item)
    {
        var options = new List<string>(item.IncorrectAnswers)
        {
            item.CorrectAnswer
        };
        Random random = new Random();
        options.Sort((a,b) => 1 - random.Next(3));
        return new QuizItemDTO()
        {
            Id = item.Id,
            Question = item.Question,
            Options = options
        };
    }
}