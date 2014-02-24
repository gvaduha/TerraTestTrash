using System;
using System.Collections;
using System.Collections.Generic;

namespace TerrasoftTestRunner
{
    /// <summary>
    /// Combine given lists rotating indexes as {000 100 200 ... 998 999}
    /// </summary>
    public class ListsCombinator
    {
        private readonly Dictionary<IList, int> _registry = new Dictionary<IList, int>();

        public ListsCombinator(IEnumerable<IList> rotatableLists)
        {
            foreach (var list in rotatableLists)
                _registry.Add(list, 0);
        }

        public T GetNextValue<T>(IList<T> list)
        {
            if (!_registry.ContainsKey((IList)list))
                    throw new ListCombinatorException();

            return list[_registry[(IList)list]];
        }

        public bool RotateLists()
        {
            var listCount = _registry.Count;
            var curListNum = 1;

            foreach (var list in new List<IList>(_registry.Keys)) //.Sort?
            {
                var idx = _registry[list];
                idx++;

                if (idx == list.Count) // rotate list and continue with next
                {
                    if (curListNum == listCount) return false; // last list overflow

                    idx = 0;
                    _registry[list] = idx;
                    curListNum++;
                    continue;
                }

                _registry[list] = idx; // save incremented current and stop
                break;
            }

            return true;
        }
    }

    public class ListCombinatorException : ApplicationException
    {}
}
