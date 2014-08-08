using ScriptCs.Contracts;

namespace ScriptCs.AgileZen
{
    public class AgileZenScriptPack : IScriptPack
    {
        public IScriptPackContext GetContext()
        {
            return new AgileZen();
        }

        public void Initialize(IScriptPackSession session)
        {
        }

        public void Terminate()
        {
        }
    }
}
