using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Utils
{
    public class Locators
    {
        //Locators for login
        public const String signInClass = "title--1NHWk gtm-login-click";
        public const String continueWithEmailXpath = "/html/body/div[3]/div/div/div/div[2]/div[2]/div/div[3]/button";
        public const String emailId = "input_email";
        public const String passwordId = "input_password";
        public const String loginXpath = "/html/body/div[3]/div/div/div/div[2]/div[2]/div/form/div[2]/div/button";

        //login credential
        public const String email = "ashiq10@gmail.com";
        public const String password = "123456789As@";

        //homepage
        public const String homepageClass = "gtm-market-logo";

        //MyAccount
        public const String myAccountClass = "header-link--woAbP title--1NHWk gtm-myaccount-click";
        public const String accountXpath = "/html/body/div[2]/div/div/div/div/div[1]/h4";
        public const String accountText = "Account";
        public const String myMembershipXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[2]/a";
        public const String myMembershipValidateXpath = "//*[@id='my-content']/h2";
        public const String myMembershipText = "My Membership";
        public const String favoritesXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[3]/a";
        public const String favoritesvalidateXpath = "//*[@id='my-content']/h2";
        public const String favoritesText = "Favorites";
        public const String settingXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[4]/a";
        public const String settingValidateXpath = "//h2[contains(text(),'Settings')]";
        public const String settingText = "Settings";
        public const String jobsvalidateXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/div/h4";
        public const String jobsText = "Jobs";
        public const String myProfileXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[5]/a";
        public const String myProfileValidateXPath = "//*[@id='my-content']/div[1]/div[1]/h1";
        public const String myProfileText = "My Profile";
        public const String profileDatabaseXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[6]/a";
        public const String profileDatabaseValidateXpath = "//*[@id='app-container']/div/div/div/div[1]/div/div[1]/h2";
        public const String profileDatabaseText = "Profile database";
        public const String myAccountXPath = "/html/body/div[1]/div/div[1]/li[1]/a[2]";

        //chat
        public const String chatClass = "title--1NHWk gtm-chat-click";

        //SignUp paths
        public const String registerClass = "btn--1gFez tertiary--5kHib small--1MQ15";
        public const String nameId = "input_name";
        public const String confirmPasswordId = "input_password-confirm";
        public const String signUpClass = "btn--1gFez secondary--Os-e9 background--2lR9B small--1MQ15 gtm-email-signup";

        //signUp crediantial
        public const String name = "Ashiq";
        public const String newEmail = "ashiq2811@gmail.com";

        //Post a Add
        public const String postyourAddClass = "anchor--2X85N header-link--woAbP post-ad-button--2bUqH gtm-postall";
        public const String lookForSomethingToBuyXpath = "//*[@id='app-wrapper']/div[1]/div[3]/div[2]/div[2]/div[3]/ul/li[2]/button";
        public const String laptopXpath = "/html/body/div[4]/div/div/div/div[2]/div/div[2]/div/ul/li[2]/button";
        public const String electronicsXpath = "/html/body/div[4]/div/div/div/div[2]/div/div/div/ul/li[3]/button";
        public const String rajshahiXpath = "/html/body/div[4]/div/div/div/div[2]/div/div/div/div[1]/div/ul/li[6]/button";
        public const String uposohorXpath = "/html/body/div[4]/div/div/div/div[2]/div/div[2]/div/div[2]/ul/li[3]/button";
        public const String titleId = "input_title";
        public const String titleText = "acer";
        public const String descripTionXpath = "//*[@id='app-wrapper']/div[1]/div[3]/div[5]/form/div[1]/div[2]/div/div[1]/textarea";
        public const String descriptionText = "This is a brand new laptop with 8 gb ram";
        public const String phoneNumberId = "input_5";
        public const String phoneNumber = "01789456521";
        public const String addNumberClass = "btn--1gFez tertiary--5kHib small--1MQ15 add-button--1JzQV gtm-submit-phone-number";
        public const String checkBoxAccept = "checkbox_id_0";




    }
}
