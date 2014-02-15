<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Index Page</title>
  </head>
  <body>
    <h1>Test</h1>
    This is a sample page doing some dummy work.
    <br/>
    <br/>
    <a href="<%= Url.Action("About", "Test") %>">Visit the About Page</a>
    <br/>
    <br/>
    <a href="<%= Url.Action("Index", "Home") %>">Visit the Home Page</a>
  </body>
</html>
