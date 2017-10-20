using System.Collections.Generic;

namespace Telephony
{
    public interface ICallable
    {
        void MakeCall(IList<string> numbers);
    }
}
