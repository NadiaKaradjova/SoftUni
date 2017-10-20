using System.Collections.Generic;

namespace Telephony
{
    public interface IBrowser
    {
        void Browse(IList<string> urls);
    }
}