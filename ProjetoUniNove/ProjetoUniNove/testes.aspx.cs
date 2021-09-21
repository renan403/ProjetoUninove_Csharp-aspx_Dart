using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace ProjetoUniNove
{
    public partial class testes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            

        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "cMpAqZLOnRIxa3cRl05bnHidcZ1gqyv2pDHixAzB",
            BasePath = "https://projetouni9-ae8d8-default-rtdb.firebaseio.com/"
        };
    }
}