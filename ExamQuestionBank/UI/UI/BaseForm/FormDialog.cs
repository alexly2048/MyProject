using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Windows.Forms;
using CustomerUI.Base;
namespace CustomerUI.UI.BaseForm
{
    public partial class FormDialog : FormBase
    {
        public FormDialog()
        {
            InitializeComponent();
        }

        public virtual void Shower(Action action, bool isAdd, object content) { }

        protected void SetIsNotBlankValidation(DXValidationProvider provider,Control targetControl,string errMsg)
        {
            ConditionValidationRule empty = new ConditionValidationRule();
            empty.ErrorText = errMsg;
            empty.ConditionOperator = ConditionOperator.IsNotBlank;
            empty.ErrorType = ErrorType.Critical;
            provider.SetValidationRule(targetControl, empty);
        }

        protected void SetNumberValidation(DXValidationProvider provider, Control targetControl, string errMsg)
        {
            CustomNumberValidationRule validation = new CustomNumberValidationRule();
            validation.ErrorText = errMsg;
            validation.ErrorType = ErrorType.Critical;
            provider.SetValidationRule(targetControl, validation);
        }
        /// <summary>
        /// If user input nothing, return true
        /// </summary>
        protected void SetOnlyNumberValidation(DXValidationProvider provider,Control control,string errMsg)
        {
            CustomOnlyNumberValidationRule validation = new CustomOnlyNumberValidationRule();
            validation.ErrorText = errMsg;
            validation.ErrorType = ErrorType.Critical;
            provider.SetValidationRule(control, validation);
        }
    }
}
