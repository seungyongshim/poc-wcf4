using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 인터페이스 이름 "IService1"을 변경할 수 있습니다.
    [ServiceContract]
    public interface IService1
    {
        //[OperationContract(AsyncPattern = true)]
        //[WebInvoke(Method = "Post", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getdataasync") ]
        //Task<string> GetDataAsync(int value);

        [OperationContract]
        [WebInvoke(Method = "Post", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "getdata")]
        string GetData(int value);

        [OperationContract]
        [WebInvoke]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: 여기에 서비스 작업을 추가합니다.
    }
}
