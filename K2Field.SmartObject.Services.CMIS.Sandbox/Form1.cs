using DotCMIS;
using DotCMIS.Client;
using DotCMIS.Client.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2Field.SmartObject.Services.CMIS.Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoSomething_Click(object sender, EventArgs e)
        {
            //http://chemistry.apache.org/dotnet/getting-started-with-dotcmis.html
            //http://stackoverflow.com.80bola.com/questions/22979885/dotcmis-createdocument-with-sharepoint-2013/22980169
            //http://www.c-sharpcorner.com/UploadFile/surya_bg2000/alfresco-integration-with-net-using-cmis/

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters[SessionParameter.BindingType] = BindingType.AtomPub;
            parameters[SessionParameter.AtomPubUrl] = "https://portal.denallix.com/_vti_bin/cmis/rest?getRepositories";
            parameters[SessionParameter.User] = "administrator@denallix.com";
            parameters[SessionParameter.Password] = "K2pass!";
            parameters[SessionParameter.AuthenticationProviderClass] = "DotCMIS.Binding.NtlmAuthenticationProvider";

            SessionFactory factory = SessionFactory.NewInstance();
            ISession session = factory.GetRepositories(parameters)[0].CreateSession();

            // Get name of first document in repository
            string firstDocName = session.GetRootFolder().GetChildren().First().Name;

            int i = 0;

        }
    }
}
