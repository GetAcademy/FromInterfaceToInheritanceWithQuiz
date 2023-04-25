using QuizWithTwoTypesOfQuestions;

/*
 * arve felt
 * arve metoder
 * arve constructor
 * ev. template method pattern
 */

var questions = new Question[]
{
    new SingleAnswerQuestion("Hva er 2+2?", "4"),
    new MultipleChoiceQuestion("Hva er hovedstaden i Norge?", 3, "Stavern", "Larvik", "Oslo"),
};

var points = 0;
foreach (var question in questions)
{
    var isCorrect = question.Run();
    if (isCorrect)
    {
        Console.WriteLine("Riktig!");
        points++;
    }
    else
    {
        Console.WriteLine("Feil :-(");
    }
}

Console.WriteLine($"Du fikk {points} poeng.");