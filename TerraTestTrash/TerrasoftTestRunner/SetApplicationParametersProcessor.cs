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
    class SetApplicationParametersProcessor
    {
        private readonly ExternalServiceSoapClient _terrasoftProxy = new ExternalServiceSoapClient("ExternalServiceSoap");
        private readonly ServiceSiteClient _servicesiteProxy = new ServiceSiteClient("BasicHttpBinding_ServiceSite");

        public SetAppStatusSession RunSample(ApplicationParameterToChoose sample)
        {
            var session = new SetAppStatusSession { Request = sample };

            try
            {
                var watch = Stopwatch.StartNew();
                session.Response = _terrasoftProxy.SetApplicationParameters(sample, ConfigurationManager.AppSettings["TerrasoftSvcPass"]);
                watch.Stop();

                session.TimeToPerform = watch.Elapsed;
            }
            catch (Exception ex)
            {
                if (session.Response == null)
                    session.Response = new ParameterResponce
                    {
                        result = new Response()
                    };

                session.Response.result.IsSuccess = false;
                session.Response.result.ErrorMessage = ex.ToString();
            }

            SendToStorageService(session);

            return session;
        }

        public IEnumerable<SetAppStatusSession> Run(IEnumerable<ApplicationParameterToChoose> samples)
        {
            return samples.Select(RunSample);
        }

        private void SendToStorageService(SetAppStatusSession session)
        {
            var badReq = new ServiceSiteBadReq
            {
                date = DateTime.Now,
                //formID = session.Response.IdApplication,
                //productType = session.Response.Status,
                //productCode = session.Response.Text,
                ErrorInto = String.Format("{0}:{1}", session.TimeToPerform, session.Response.result.ErrorMessage),
                host = "Test58",
                request = session.GetRequest(),
                IsIntoOk = session.Response.result.IsSuccess,
                NumberStep = Convert.ToInt32(GlobalRegistry.Objects["ThreadNum"]), // hardly incorrect to put it here so lame solution
            };

            session.IsSessionSavedToStorage = _servicesiteProxy.BadRequest(ConfigurationManager.AppSettings["StorageSvcPass"], badReq);
        }
    }
}
