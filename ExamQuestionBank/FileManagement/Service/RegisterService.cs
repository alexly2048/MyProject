using Autofac;
using CommonService;
using DBHelper;
using FileManagement.UI;
using IOCService.Service;
using CustomerUI.DBService.CommonService;
using CustomerUI;
using CustomerUI.UI.Common;
using CustomerUI.UI.QuestionBank;
using CustomerUI.DBService.QuestionService;

namespace FileManagement.Service.BaseService
{
    public partial class RegisterService
    {
        private RegisterService()
        {

        }
        private static ContainerBuilder builder = new ContainerBuilder();
        public static void Register()
        {

            builder.RegisterType<FileHelperService>().SingleInstance();

            builder.RegisterType<DatabaseService>().As<IDatabaseService>().SingleInstance();
            builder.RegisterType<UserService>().SingleInstance();
            builder.RegisterType<AuthoritiesService>().SingleInstance();
            builder.RegisterType<FunctionItemService>().SingleInstance();           
            builder.RegisterType<AppHost>().SingleInstance();

            builder.RegisterType<CourseService>().SingleInstance();
            builder.RegisterType<AnswerService>().SingleInstance();
            builder.RegisterType<QuestionService>().SingleInstance();
            builder.RegisterType<QuestionItemService>().SingleInstance();
            builder.RegisterType<QuestionImageService>().SingleInstance();
            builder.RegisterType<SubjectDescriptionService>().SingleInstance();
            builder.RegisterType<SubjectService>().SingleInstance();
            builder.RegisterType<QuestionViewService>().SingleInstance();
            builder.RegisterType<DisplayQuestionViewService>().SingleInstance();
            builder.RegisterType<GradeService>().SingleInstance();
            builder.RegisterType<ExamBankService>().SingleInstance();
            builder.RegisterType<UserExamService>().SingleInstance();
            builder.RegisterType<GenerateExamContentService>().SingleInstance();

            builder.RegisterType<FrmMain>().InstancePerLifetimeScope();
            builder.RegisterType<FrmLogin>().InstancePerLifetimeScope();
            builder.RegisterType<FrmUser>().InstancePerLifetimeScope();
            builder.RegisterType<FrmEditUser>().InstancePerLifetimeScope();
            builder.RegisterType<FrmAuthority>().InstancePerLifetimeScope();
            builder.RegisterType<FrmFunctionItem>().InstancePerLifetimeScope();
            
            builder.RegisterType<FormExam>().InstancePerLifetimeScope();
            builder.RegisterType<FormManageQuestion>().InstancePerLifetimeScope();
            builder.RegisterType<FormAddQuestion>().InstancePerLifetimeScope();
            builder.RegisterType<FormEditQuestion>().InstancePerLifetimeScope();
            builder.RegisterType<FormCourse>().InstancePerLifetimeScope();
            builder.RegisterType<FormEditCourse>().InstancePerLifetimeScope();
            builder.RegisterType<FormSubjectDescription>().InstancePerLifetimeScope();
            builder.RegisterType<FormQuestionImages>().InstancePerLifetimeScope();
            builder.RegisterType<FormGrade>().InstancePerLifetimeScope();
            builder.RegisterType<FormEditGrade>().InstancePerLifetimeScope();
            builder.RegisterType<FormExamBank>().InstancePerLifetimeScope();
            builder.RegisterType<FormEditExamBank>().InstancePerLifetimeScope();
            builder.RegisterType<FormManageUserExam>().InstancePerLifetimeScope();
            builder.RegisterType<FormEditUserExam>().InstancePerLifetimeScope();
            builder.RegisterType<FormSelectExam>().InstancePerLifetimeScope();
            builder.RegisterType<FormCheckExam>().InstancePerLifetimeScope();
            builder.RegisterType<FormUserExamHistory>().InstancePerLifetimeScope();
            builder.RegisterType<FormDisplayScore>().InstancePerLifetimeScope();
            builder.RegisterType<FormDisplayImage>().InstancePerLifetimeScope();
            AppContainer.Container = builder.Build();
        }
    }
}
