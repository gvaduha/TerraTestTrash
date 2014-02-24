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
    class GetAppStatusRequestProcessor
    {
        private readonly ExternalServiceSoapClient _terrasoftProxy = new ExternalServiceSoapClient("ExternalServiceSoap");
        private readonly ServiceSiteClient _servicesiteProxy = new ServiceSiteClient("BasicHttpBinding_ServiceSite");

        public GetAppStatusSession RunSample(ApplicationStatusRequest sample)
        {
            var session = new GetAppStatusSession { Request = sample };

            try
            {
                var watch = Stopwatch.StartNew();
                session.Response = _terrasoftProxy.GetApplicationStatus(sample, ConfigurationManager.AppSettings["TerrasoftSvcPass"]);
                watch.Stop();

                session.TimeToPerform = watch.Elapsed;
            }
            catch (Exception ex)
            {
                if (session.Response == null)
                    session.Response = new ApplicationStatusResponse
                    {
                        result = new Response()
                    };

                session.Response.result.IsSuccess = false;
                session.Response.result.ErrorMessage = ex.ToString();
            }

            SendToStorageService(session);

            return session;
        }

        public IEnumerable<GetAppStatusSession> Run(IEnumerable<ApplicationStatusRequest> samples)
        {
            return samples.Select(RunSample);
        }

        private void SendToStorageService(GetAppStatusSession session)
        {
            var badReq = new ServiceSiteBadReq
            {
                date = DateTime.Now,
                formID = session.Response.IdApplication,
                productType = session.Response.Status,
                productCode = session.Response.Text,
                host = "Test103",
                request = session.GetRequest(),
                IsIntoOk = session.Response.result.IsSuccess,
                NumberStep = Convert.ToInt32(GlobalRegistry.Objects["ThreadNum"]), // hardly incorrect to put it here so lame solution
            };

            if (!badReq.IsIntoOk)
                badReq.ErrorInto = String.Format("{0}:{1}", session.TimeToPerform, session.Response.result.ErrorMessage);
            else
                badReq.ErrorInto = session.GetResponse();

            session.IsSessionSavedToStorage = _servicesiteProxy.BadRequest(ConfigurationManager.AppSettings["StorageSvcPass"], badReq);

            var nres = session.Response.results.Length;

            if (nres <= 0) return;

            var s = session.Response.results[new Random().Next(0, nres)];

            var badReq2 = new ServiceSiteBadReq
            {
                date = DateTime.Now,
                formID = s.ID,
                productCode = s.Text,
                host = "Test58",
                request = session.GetRequest(),
            };

            session.IsSessionSavedToStorage = _servicesiteProxy.BadRequest(ConfigurationManager.AppSettings["StorageSvcPass"], badReq2);
        }
    }
}
