<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
  <head id="Head1" runat="server">
    <title>About Page</title>
  </head>
  <body>
    <h1>About</h1>
    This is the about page doing some dummy work.
    <br/>
    <br/>
    <a href="<%= Url.Action("Index", "Test") %>">Back to Index</a>
  </body>
</html>
