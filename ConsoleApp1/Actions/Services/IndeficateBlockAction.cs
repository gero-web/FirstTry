using CompreseCodeHumffman.Actions.Interfaces;
using CompreseCodeHumffman.Model;

namespace CompreseCodeHumffman.Actions.Services
{
    public class IndeficateBlockAction : IAction<Block>
    {
        public string Do(Block block)
        {
            return block.Code;
        }
    }
}
