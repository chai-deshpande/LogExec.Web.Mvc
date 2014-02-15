<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Home</title>
  </head>
  <body>
    <h1>Home</h1>
    This is the home page.
    <br/>
    <br/>
    <a href="<%= Url.Action("Index", "Test") %>">Visit the Index Page of the Test Controller</a>
  </body>
</html>
