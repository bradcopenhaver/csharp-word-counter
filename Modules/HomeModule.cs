using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>
      {
        RepeatCounter newCounter = new RepeatCounter(Request.Form["searchWord"], Request.Form["searchText"]);
        int count = newCounter.CountRepeats();
        return View["result.cshtml", newCounter];
      };
    }
  }
}
