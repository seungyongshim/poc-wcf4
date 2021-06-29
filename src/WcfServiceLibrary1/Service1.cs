namespace WcfServiceLibrary1
{
    using System;
    using System.IO;
    using System.ServiceModel.Web;
    using System.Text;

    public class Service1 : IService1
    {
        public Stream GetData1(int value)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes($"You entered: {value}"));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
