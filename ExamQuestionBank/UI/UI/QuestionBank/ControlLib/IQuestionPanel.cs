using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUI.UI.QuestionBank.ControlLib
{
    interface IQuestionPanel
    {
        void BindingData<T>(T obj);
        string GetAnswers();
    }
}
