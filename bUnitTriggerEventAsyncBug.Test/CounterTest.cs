using Bunit;
using bUnitTriggerEventAsyncBug.Client.Pages;
using Xunit;

namespace bUnitTriggerEventAsyncBug.Test
{
  public class CounterTest : TestContext
  {
    [Fact]
    private void ClickException()
    {
      var cut = RenderComponent<Counter>();

      cut.Find("button").Click();
    }
  }
}
