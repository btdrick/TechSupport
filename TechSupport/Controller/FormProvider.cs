using TechSupport.View;

namespace TechSupport.Controller
{
    public class FormProvider
    {
        public static MainForm MainForm
        {
            get
            {
                if (_mainForm == null)
                {
                    _mainForm = new MainForm();
                }
                return _mainForm;
            }
        }
        private static MainForm _mainForm;

        public static LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    _loginForm = new LoginForm();
                }
                return _loginForm;
            }
        }
        private static LoginForm _loginForm;
    }
}
