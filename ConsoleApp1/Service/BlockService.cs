using CompreseCodeHumffman.Actions.Services;
using CompreseCodeHumffman.Interface;
using CompreseCodeHumffman.Model;

namespace CompreseCodeHumffman.Service
{
    public class BlockService : IExcuter<Block, IndeficateBlockAction>
    {
        public void Execute(IndeficateBlockAction action)
        {
            var block = new Block();
            Console.WriteLine(action.Do(block));
        }
    }
}
