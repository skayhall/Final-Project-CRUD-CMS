<%@ Page Title="List of Pages" Language="C#" MasterPageFile="~/Layout.Master" 
    AutoEventWireup="true" CodeBehind="ListPageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.ListPageCMS" %>


<asp:Content ID="pagecms_list" ContentPlaceHolderID="body" runat="server">
    <h1>Pages</h1>
    <div id="pagecms_nav">
        <asp:label for="pagecms_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="pagecms_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="submit"/>

    </div>
    <a href="NewPageCMS.aspx">Add New Page</a>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col2 col2header" >Page Title</div>
            <div class="col2last col2header">Page Content</div>
        </div>
        <div id="pagecms_result" runat="server">

        </div>
    </div>
</asp:Content>
