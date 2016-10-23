using RetroTip.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RetroTip.Web.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private string pushFundsRequest;
        private VisaAPIClient visaAPIClient;


        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {


        }

        public void LoginUser()
        {

        }

        public void RegisterUser()
        {

        }

        public void AddCreditCard()
        {

        }

        public void AddBankAccount()
        {

        }

        public IHttpActionResult SendPayment(int amount)
        {
            try
            {
                string baseUri = "visadirect/";
                string resourcePath = "fundstransfer/v1/pushfundstransactions";
                string status = visaAPIClient.DoMutualAuthCall(baseUri + resourcePath, "POST", "Push Funds Transaction Test", pushFundsRequest);
            }
            catch
            {

            }

            return Ok(amount);
        }

        public IHttpActionResult UpdateUserBalance(int amount)
        {
            try
            {

            }
            catch
            {

            }

            return Ok(amount);
        }

        public object GetUserBalance()
        {
            return new { balance = "$5.00" };
        }
    }
}
