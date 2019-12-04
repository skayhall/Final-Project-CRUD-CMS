<%@ Page Title="Page View" Language="C#" MasterPageFile="~/Layout.Master" 
    AutoEventWireup="true" CodeBehind="ShowPageCMS.aspx.cs" 
    Inherits="FinalProject_PagesCMS.ShowPageCMS" %>




<asp:Content ID="page_view" ContentPlaceHolderID="body" runat="server">


    <div class="viewnav">
        <a class="left" href="ListPageCMS.aspx">Back To List</a>
        
           
    </div>
    <div id="pagecms" runat="server">
        <div id="page_title" runat="server"></div>
        <div id="page_body" runat="server"></div><br />
      

    </div>


     <ASP:Button OnClientClick="if(!confirm('Are you sure you want to delete this page?')) 
            return false;" OnClick="Delete_PageCMS" CssClass="right spaced" Text="Delete" 
            runat="server"/>   
     <a class="right" href="UpdatePageCMS.aspx?pagecmsid=<%= Request.QueryString["pagecmsid"] %>">Edit</a>

</asp:Content>