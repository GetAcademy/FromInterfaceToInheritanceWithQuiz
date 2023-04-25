namespace QuizWithTwoTypesOfQuestions.WithInterface
{
    internal class SingleAnswerQuestion : IQuestion
    {
        private readonly string _question;
        private readonly string _correctAnswer;

        public SingleAnswerQuestion(string question, string correctAnswer)
        {
            _correctAnswer = correctAnswer;
            _question = question;
        }

        public bool Run()
        {
            Console.Write(_question + " ");
            var answer = Console.ReadLine();
            return answer == _correctAnswer;
        }
    }
}
