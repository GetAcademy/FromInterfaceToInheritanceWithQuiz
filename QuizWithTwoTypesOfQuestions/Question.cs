using QuizWithTwoTypesOfQuestions.WithInterface;

namespace QuizWithTwoTypesOfQuestions
{
    internal class Question
    {
        private readonly string _question;

        public Question(string question)
        {
            _question = question;
        }

        public virtual bool Run()
        {
            Console.WriteLine(_question);
            return true;
        }
    }
}
