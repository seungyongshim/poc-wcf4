namespace WcfServiceLibrary1
{
    using System.IO;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Web;

    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 인터페이스 이름 "IService1"을 변경할 수 있습니다.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getdata1")]
        Stream GetData1(int value);

        [OperationContract]
        [WebInvoke]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
