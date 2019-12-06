<%@ Page Title="List of Pages" Language="C#" MasterPageFile="~/Layout.Master" 
    AutoEventWireup="true" CodeBehind="ListPageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.ListPageCMS" %>


<asp:Content ID="pagecms_list" ContentPlaceHolderID="body" runat="server">
    <h2>Pages</h2>
    <div id="search_listpage">
        <asp:label for="pagecms_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="pagecms_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="submit"/>
        <div id="sql_searcher" runat="server"></div>

    </div>
    <br /><a href="NewPageCMS.aspx">Add New Page</a>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col2 col2header" >Page Title</div>
            <div class="col2last col2header">Page Content</div>
        </div>
        <div id="pagecms_result" runat="server"></div>
    </div>
</asp:Content>
