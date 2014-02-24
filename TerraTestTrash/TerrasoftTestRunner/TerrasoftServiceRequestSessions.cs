using System;
using System.IO;
using System.Xml.Serialization;
using Test_I102.ServiceReferenceTerrasoft;

namespace TerrasoftTestRunner
{
    public class TerrasoftBaseSession
    {
        public TimeSpan TimeToPerform { get; set; }
        public bool IsSessionSavedToStorage { get; set; }

        public static string SerializeObject<T>(T toSerialize)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(toSerialize.GetType());
                var textWriter = new StringWriter();

                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }

    public class UploadAppSession : TerrasoftBaseSession
    {
        public GenericApplication Request { get; set; }
        public Response Response { get; set; }

        public ApplicationTypes ApplicationType { get { return Request.GenericInfo.ApplicationType; }}
        public string BankingService { get { return Request.GenericInfo.BankingService; } }
        public string SmsCode { get { return Request.GenericInfo.SMScode; } }
        public string PhoneNumber { get { return Request.GenericInfo.ContactPhone; }}

        public string ResponseCode { get { return Response.ErrorCode; } }
        public string ResponseMsg { get { return Response.ErrorMessage; } }
        public bool ResponseOk { get { return Response.IsSuccess; }}

        public string GetRequest()
        {
            return SerializeObject(Request);
        }
    }

    public class GetAppStatusSession : TerrasoftBaseSession
    {
        public ApplicationStatusRequest Request { get; set; }
        public ApplicationStatusResponse Response { get; set; }

        public string GetRequest()
        {
            return SerializeObject(Request);
        }

        public string GetResponse()
        {
            return SerializeObject(Response);
        }
    }

    internal class SetAppStatusSession : TerrasoftBaseSession
    {
        public ApplicationParameterToChoose Request { get; set; }
        public ParameterResponce Response { get; set; }

        public string GetRequest()
        {
            return SerializeObject(Request);
        }
    }
}
