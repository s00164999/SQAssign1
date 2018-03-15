using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQAssign1;

namespace SQAssign1Web
{
    public partial class PremiumTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            try
            {
                c.setProperties(int.Parse(ageTB.Text), genderDDL.SelectedValue);
                outputLabel.Text = c.CalcPremium().ToString();
            }
            catch (Exception ex)
            {
                outputLabel.Text = ex.Message;
            }
        }
    }
}