using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Test_I102.ServiceReferenceTerrasoft;

namespace TerrasoftTestRunner
{
    class RandomUploadAppRequestBuilder : UploadAppRequestBuilder
    {
        private readonly Random _rnd = new Random();

        protected override string GetNextDigitSequence(int length)
        {
            var rnd = new Random();

            return Enumerable.Range(1, length).Aggregate("", (current, i) => current + rnd.Next(0, 10));
        }

        protected override string GetNextAlphaNumSequence(int length)
        {
            return Path.GetRandomFileName().Replace(".", "").Substring(0, length);
        }

        protected override T GetNextValue<T>(IList<T> list)
        {
            return list[_rnd.Next(0, list.Count)];
        }

        protected override DateTime GetNextRangeValue(IList<DateTime> range)
        {
            var from = range[0];
            var to = range[1];
            return from.AddDays(_rnd.Next(0, (int)((to - from)).TotalDays)); //TODO: unsafe conversion
        }

        protected override int GetNextRangeValue(IList<int> range)
        {
            return _rnd.Next(range[0], range[1]);
        }

        public override IEnumerable<GenericApplication> Build(UploadAppSampleDataDictionary dataDictionary)
        {
            while (true)
                yield return ConstructObject(dataDictionary);
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
