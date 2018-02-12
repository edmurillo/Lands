using System;
namespace Lands.ViewModels
{
    public class LoginViewModel
    {
        #region
        public String Email
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public String Remembered
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public Login()
        {
           
        }
        #endregion

        #region Commands
        public String Buttoncommand
        {
            get;
            set;
        }
        #endregion
    }
}
