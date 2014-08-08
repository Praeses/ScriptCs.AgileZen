using ScriptCs.AgileZen.Models;
using ScriptCs.Contracts;

namespace ScriptCs.AgileZen
{
    public class AgileZen : IScriptPackContext
    {
        public AgileZenClient GetClient(string apiKey)
        {
            return new AgileZenClient(apiKey);
        }
    }
}
