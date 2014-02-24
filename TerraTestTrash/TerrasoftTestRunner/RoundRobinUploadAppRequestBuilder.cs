using System.Collections;
using System.Collections.Generic;
using Test_I102.ServiceReferenceTerrasoft;

namespace TerrasoftTestRunner
{
    class RoundRobinUploadAppRequestBuilder : RandomUploadAppRequestBuilder
    {
        private readonly ListsCombinator _comb;

        public RoundRobinUploadAppRequestBuilder(IEnumerable<IList> lists)
        {
            _comb = new ListsCombinator(lists);
        }

        protected override T GetNextValue<T>(IList<T> list)
        {
            // Get list's next value or call base random getter
            try
            {
                return _comb.GetNextValue(list);
            }
            catch (ListCombinatorException)
            {
                return base.GetNextValue(list);
            }
        }

        public override IEnumerable<GenericApplication> Build(UploadAppSampleDataDictionary dataDictionary)
        {
            //TODO: here is logic bug: 
            // once processes aquired wait on data collection could be exausted
            // so last record of dictionary replay by all threads
            bool hasMoreData;
            do
            {
                lock (dataDictionary)
                {
                    yield return ConstructObject(dataDictionary);
                    hasMoreData = _comb.RotateLists();
                }
            } while (hasMoreData);
        }
    }
}
