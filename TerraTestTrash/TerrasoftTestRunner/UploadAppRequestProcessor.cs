using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Test_I102;
using Test_I102.ServiceReferenceTerrasoft;
using Test_I102.ServiceSite;

namespace TerrasoftTestRunner
{
	public class UploadAppRequestProcessor
	{
	    private readonly ExternalServiceSoapClient _terrasoftProxy = new ExternalServiceSoapClient("ExternalServiceSoap");
        private readonly ServiceSiteClient _servicesiteProxy = new ServiceSiteClient("BasicHttpBinding_ServiceSite");

        public UploadAppSession RunSample(GenericApplication sample)
        {
            var session = new UploadAppSession {Request = sample};

            try
            {
                var watch = Stopwatch.StartNew();
                session.Response = _terrasoftProxy.UploadApplication(session.Request, ConfigurationManager.AppSettings["TerrasoftSvcPass"]);
                watch.Stop();

                session.TimeToPerform = watch.Elapsed;
            }
            catch (Exception ex)
            {
                if(session.Response == null)
                    session.Response = new Response();

                session.Response.IsSuccess = false;
                session.Response.ErrorMessage = ex.ToString();
            }

            SendToStorageService(session);

            return session;
        }

        public IEnumerable<UploadAppSession> Run(IEnumerable<GenericApplication> samples)
        {
            return samples.Select(RunSample);
        }

	    private void SendToStorageService(UploadAppSession session)
	    {
	        var badReq = new ServiceSiteBadReq
	        {
	            date = DateTime.Now,
	            productType = session.ApplicationType.ToString(),
	            productCode = session.BankingService,
	            phoneNumber = session.PhoneNumber,
	            ErrorInto = String.Format("{0}:{1}",session.TimeToPerform,session.ResponseMsg),
	            formID = session.SmsCode,
	            host = "Test",
	            request = session.GetRequest(),
	            IsIntoOk = session.ResponseOk,
                NumberStep = Convert.ToInt32(GlobalRegistry.Objects["ThreadNum"]), // hardly incorrect to put it here so lame solution
	        };

            session.IsSessionSavedToStorage = _servicesiteProxy.BadRequest(ConfigurationManager.AppSettings["StorageSvcPass"], badReq);
	    }
   }
}
