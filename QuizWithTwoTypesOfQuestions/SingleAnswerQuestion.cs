namespace QuizWithTwoTypesOfQuestions
{
    internal class SingleAnswerQuestion : Question
    {
        private readonly string _question;
        private readonly string _correctAnswer;

        public SingleAnswerQuestion(string question, string correctAnswer)
        {
            _correctAnswer = correctAnswer;
            _question = question;
        }

        public override bool Run()
        {
            Console.Write(_question + " ");
            var answer = Console.ReadLine();
            return answer == _correctAnswer;
        }
    }
}
