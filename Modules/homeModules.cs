using Nancy;
using System.Collections.Generic;

namespace RectangleChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["rectangle_form.cshtml"];
      };
      Get["/rectangle_result"] = _ => {
        Dictionary<string, object> Shapes = new Dictionary<string, object>();
        Rectangle myRectangle = new Rectangle(Request.Query["side-length"], Request.Query["side-width"]);
        Shapes.Add("ResultingRectangle", myRectangle);

        if (myRectangle.IsSquare()) {
          Cube myCube = new Cube(myRectangle);
          Shapes.Add("ResultingCube", myCube);
        }
        return View["rectangle_result.cshtml", Shapes];
      };
    }
  }
}
