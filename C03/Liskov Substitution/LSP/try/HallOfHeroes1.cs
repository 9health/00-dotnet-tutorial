using LSP.Models;

namespace tryLSP.Examples.Update1;

public class HallOfHeroes : HallOfFame
{
    public override void Add(Ninja ninja)
    {
        if (InternalMembers.Contains(ninja))
        {
            return;
        }
        InternalMembers.Add(ninja);
    }
}
