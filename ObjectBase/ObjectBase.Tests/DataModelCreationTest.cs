using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectBase.Core.DataModel;

namespace ObjectBase.Tests
{
    [TestClass]
    public class DataModelCreationTest
    {
        [TestMethod]
        public void CreateSimple()
        {
            DatabaseModel model = new DatabaseModel("EasyModel",
                m => m.AddEntity("User",
                    e => e.AddProperty(DataType.StringType, "Login")
                            .AddProperty(DataType.StringType, "Password"))
                );


        }
    }
}
