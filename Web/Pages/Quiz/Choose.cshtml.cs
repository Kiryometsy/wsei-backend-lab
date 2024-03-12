using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendLab01.Pages.Quiz
{
    public class Choose : PageModel
    {
        private readonly IQuizUserService _userService;

        private readonly ILogger _logger;
        public Choose(IQuizUserService userService, ILogger<QuizModel> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public List<BackendLab01.Quiz> lista;
        public int quizId;

        public void OnGet()
        {
            lista = _userService.GetAllQuiz();
        }
    }
}
