<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" 
    CodeBehind="NewPageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.NewPageCMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

     <h2>Add a New Page</h2>
    <div class="formrow">
        <label>Page Title</label><br />
        <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
         <%//Validation checker for page title text %>
         <asp:RequiredFieldValidator runat="server" ControlToValidate="page_title"
            ErrorMessage="Please enter a page title. This cannot be blank."></asp:RequiredFieldValidator>
    </div>
    <div class="formrow">
        <br /><label>Write Something</label><br />
        <asp:TextBox runat="server" ID="page_body" TextMode="MultiLine" Rows="10" ></asp:TextBox>
        <%//Validation checker for page body text %>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="page_body"
        ErrorMessage="Please write about something. This cannot be blank."></asp:RequiredFieldValidator>
    </div>
    <asp:Button Text="Add Page" OnClick="Add_PageCMS" runat="server" />
</asp:Content>

