using System.Threading.Tasks;
using Orleans;
using orleans1;

namespace grain
{
    public class HelloGrain : Orleans.Grain, orleans1.IHello
    {
        Task<string> IHello.SayHello(string greeting)
        {
            return Task.FromResult($"You said: '{greeting}', I say: Hello!");
        }
    }
}