<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" 
    CodeBehind="NewPageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.NewPageCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

     <h2>Add a New Page</h2>
    <div class="formrow">
        <label>Page Title</label><br />
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
    </div>
    <div class="formrow">
        <label>Write Something</label><br />
        <asp:TextBox runat="server" ID="page_body" TextMode="MultiLine" Rows="10" ></asp:TextBox>
    </div>
    <asp:Button Text="Add Page" OnClick="Add_PageCMS" runat="server" />
</asp:Content>

