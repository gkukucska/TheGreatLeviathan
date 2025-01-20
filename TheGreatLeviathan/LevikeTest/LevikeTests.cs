using NUnit.Framework.Internal;
using TheGreatLeviathan;

namespace LevikeTest;

public class LevikeTests
{
    [Test]
    public void Levike_Was_Born()
    {
        Assert.That(Levike.IsBorn(DateTime.Now));
        //Levike was born :)
    }
}