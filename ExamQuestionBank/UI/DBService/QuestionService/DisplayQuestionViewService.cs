using CustomerUI.Model;
using CustomerUI.Model.QuestionBankModel;
using DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.DBService.QuestionService
{
    public class DisplayQuestionViewService
    {
        public DisplayQuestionViewService(IDatabaseService service)
        {
            this.service = service;
        }
        private readonly IDatabaseService service;

        public IEnumerable<DisplayQuestionView> GetDisplayQuestionViews(SearchItemView search)
        {
            var r = service.GetAll<DisplayQuestionView>();
            if (search.QuestionType.HasValue)
            {
                r = r.Where(x => x.QUESTION_TYPE == search.QuestionType);
            }
            if (!string.IsNullOrEmpty(search.Keyword))
            {
                r = r.Where(x => x.QUESTION_CONTENT.Contains(search.Keyword) || x.COURSE_NAME.Contains(search.Keyword));
            }
            return r;
        }
    }
}
