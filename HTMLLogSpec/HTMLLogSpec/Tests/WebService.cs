using Magenic.Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.WebService;

namespace Tests
{
    /// <summary>
    /// Sample test class
    /// </summary>
    [TestClass]
    public class WebService : BaseWebServiceTest
    {

        /// <summary>
        /// Get single product as Json
        /// </summary>
        [TestMethod]
        public void StepWiseAPITest()
        {
            this.Log.LogMessage("INTENT: Get a product in JSON format");
            ProductJson result = this.WebServiceDriver.Get<ProductJson>("/api/XML_JSON/GetProduct/1", "application/json", false);
            SoftAssert.IsTrue(result != null, "GetProduct", "Unable to get known product");

            this.Log.LogMessage("INTENT: Post a new product with Json Format");
            result.Id = 9999;
            result.Name = "NewProduct";
            result.Price = 9.29;

            var content = WebServiceUtils.MakeStreamContent<ProductJson>(result, System.Text.Encoding.UTF8, "application/json");
            var result1 = this.WebServiceDriver.Post<ProductJson>("/api/XML_JSON/Post", "application/json", content);
            SoftAssert.IsTrue(result1 == null, "Post Product", "Unable to post a new product");
        }
    }
}
