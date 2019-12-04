<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" 
    CodeBehind="UpdatePageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.UpdatePageCMS" %>

<asp:Content ID="updatepage" ContentPlaceHolderID="body" runat="server">
    <div id="PageCMS" runat="server">
        <div class="viewnav">
            <a class="left" href="ShowPageCMS.aspx?pagecmsid=<%=Request.QueryString["pagecmsid"] %>">Cancel</a>
        </div>
        <h2>Updating Page<span id="student_title" runat="server"></span></h2>
        
        <div class="formrow">
            <label>Page Title</label>
            <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
        </div>
        <div class="formrow">
            <label>Page Body</label>
            <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
        </div>

        <asp:Button Text="Update Page"  runat="server" />
    </div>
</asp:Content>