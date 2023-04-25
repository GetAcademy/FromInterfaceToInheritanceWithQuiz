namespace QuizWithTwoTypesOfQuestions
{
    internal class SingleAnswerQuestion : Question
    {
        private readonly string _correctAnswer;

        public SingleAnswerQuestion(
            string question,
            string correctAnswer)
        : base(question)
        {
            _correctAnswer = correctAnswer;
        }

        public override bool Run()
        {
            base.Run();
            var answer = Console.ReadLine();
            return answer == _correctAnswer;
        }
    }
}
