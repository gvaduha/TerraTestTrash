using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Test_I102;
using Test_I102.ServiceReferenceTerrasoft;

namespace TerrasoftTestRunner
{
    public class TestPerformer
    {
        async public static Task ExecuteInThreads(int threads, Action action)
        {
            var tasks = new List<Task>(threads);

            for (var thr = 0; thr < threads; ++thr)
            {
                var t = Task.Run(action);

                tasks.Add(t);
            }

            foreach (var t in tasks)
                await t;
        }

        async public static Task UploadRequests(int requests, int threads, UploadAppSampleDataDictionary sampleDataDictionary,
            UploadAppRequestBuilder dataBuilder, IProgress<UploadAppSession> progressReporter, CancellationToken ct)
        {
            var samples = dataBuilder.Build(sampleDataDictionary);
            var proc = new UploadAppRequestProcessor();

            await ExecuteInThreads(threads,
                () =>
                {
                    foreach (var r in proc.Run(samples.Take(requests)))
                    {
                        progressReporter.Report(r);

                        //ct.ThrowIfCancellationRequested(); //seems it's not worked for multiple threads
                        if (ct.IsCancellationRequested) return;
                    }
                });
        }

        async public static Task GetStatusRequests(DateTime from, DateTime to, int threads,
            IProgress<GetAppStatusSession> progressReporter, CancellationToken ct)
        {
            var storageRetriverProxy = new FakeStorageRetrieverSvc(); //Service1Client()
            var samples = storageRetriverProxy.GetData(from, to).Select(x => new ApplicationStatusRequest{smsCode = x.Code, tel = x.Phone});

            var proc = new GetAppStatusRequestProcessor();

            await ExecuteInThreads(1,
                () =>
                {
                    foreach (var r in proc.Run(samples))
                    {
                        progressReporter.Report(r);

                        //ct.ThrowIfCancellationRequested(); //seems it's not worked for multiple threads
                        if (ct.IsCancellationRequested) return;
                    }
                });
        }

        public static void GET_SET_APP_PARAMS()
        {
            var sample = new ApplicationParameterToChoose
            {
                ApplicationNumber = "",
                ParameterGroupNumber = ""
            };

            new SetApplicationParametersProcessor().RunSample(sample);
        }
    }
}
