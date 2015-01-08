using EnglishQuiz.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Threading;
using System.Web.Http.Description;

namespace EnglishQuiz.Controllers
{
    public class QuestionsController : ApiController
    {
        private QuizContext db = new QuizContext();
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }


        [Route("api/gameApi/{gameId}")]
        public IEnumerable<Question> GetAllQuestionsForGame(int gameId)
        {
            if (gameId >= 0)
            {
                return db.Questions.Where(q => q.GameId == gameId);
            }
            else
                return db.Questions;
        }

        public IEnumerable<Question> GetAllQuestions()
        {

            return db.Questions;
        }

        public IHttpActionResult GetQuestion(int id)
        {
            var question = db.Questions.FirstOrDefault(q => q.Id == id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }
        

    }
}
