using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Service
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service : System.Web.Services.WebService
{

    public Service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    string[,] stocks = { 
        { "Infy", "Infosys", "122.35"},
        {"TCS", "Tata Consultancy Services", "98.22" },
        {"ASN", "Aayush Singh", "134.31" },
        {"Wipro","Wipro Limited", "117.88" }
    };

    [WebMethod]
    public double getPrice(string symbol)
    {
for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if(string.Compare(symbol, stocks[i, 0], true) == 0)
            {
                return Convert.ToDouble (stocks[i, 2]);
                }
            }
        return 0;
        }

    [WebMethod]
    public string getName(string symbol)
    {
        for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if (string.Compare(symbol, stocks[i, 0], true) == 0)
            {
                return stocks[i, 1];
            }
        }
        return "Stock not found";
    }
}
