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

            var questions = new List<Question>();

            questions.Add(new Question { 
            GameId= (int) Game.Britam,
            Choice1="trolley",
            Choice2="cart",
            Image="cart.jpg"
            });

            questions.Add(new Question
            {
                GameId = (int) Game.Britam,
                Choice1 = "lift",
                Choice2 = "elevator",
                Image = "elevator.jpg"
            });

            questions.Add(new Question
            {
                GameId = (int)Game.Britam,
                Choice1 = "chemist",
                Choice2 = "pharmacist",
                Image = "pharmacist.jpg"
            });

            questions.Add(new Question
            {
                GameId = (int) Game.Japanese,
                Choice1 = "skinship",
                Choice2 = "affection",
                Image = ""
            });

            questions.Add(new Question
            {
                GameId = (int) Game.Japanese,
                Choice1 = "renewal",
                Choice2 = "renovated",
                Image = ""
            });

            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();
        }
    }
}