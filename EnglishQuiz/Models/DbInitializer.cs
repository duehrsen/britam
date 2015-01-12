using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EnglishQuiz.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<QuizContext>
    {
        protected override void Seed(QuizContext context)
        {
            base.Seed(context);

            var questions = new List<Question>
            {
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "trolley",
                    Choice2 = "cart",
                    Image = "cart.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "lift",
                    Choice2 = "elevator",
                    Image = "elevator.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "chemist",
                    Choice2 = "pharmacist",
                    Image = "pharmacist.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Japanese,
                    Choice1 = "skinship",
                    Choice2 = "affection",
                    Image = "gokusen.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Japanese,
                    Choice1 = "renewal",
                    Choice2 = "renovated",
                    Image = "gokusen.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "underground",
                    Choice2 = "subway",
                    Image = "subway.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "bonnet",
                    Choice2 = "hood",
                    Image = "hood.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "city centre",
                    Choice2 = "downtown",
                    Image = "downtown.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "car park",
                    Choice2 = "parking lot",
                    Image = "parkinglot.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "petrol station",
                    Choice2 = "gas station",
                    Image = "gasstation.jpg"
                },
                new Question
                {
                    GameId = (int) Game.Britam,
                    Choice1 = "windscreen",
                    Choice2 = "windshield",
                    Image = "windshield.jpg"
                }
            };

            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();
        }
    }
}