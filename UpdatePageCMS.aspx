<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" 
    CodeBehind="UpdatePageCMS.aspx.cs" Inherits="FinalProject_PagesCMS.UpdatePageCMS" %>

<asp:Content ID="updatepage" ContentPlaceHolderID="body" runat="server">
    <div id="PageUpdateCMS" runat="server">
        <div class="viewnav">
              <a class="left" href="ShowPageCMS.aspx?pagecmsid=<%=Request.QueryString["pagecmsid"] %>">Cancel</a>
       
        </div>
        <h2>Update Page<span id="student_title" runat="server"></span></h2>
        
        <div class="formrow">
            <label>Update Page Title</label><br />
            <asp:TextBox runat="server" ID="pagecms_title"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="pagecms_title"
            ErrorMessage="Please enter a page title. This cannot be blank."></asp:RequiredFieldValidator>
        </div>
        <br /><div class="formrow">
            <label>Update Content</label><br />
            <asp:TextBox runat="server" ID="pagecms_body" TextMode="MultiLine" Rows="10"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="pagecms_body"
            ErrorMessage="Please update/write about something. This cannot be blank."></asp:RequiredFieldValidator>
        </div>

        <asp:Button Text="Update Page" OnClick="Update_PageCMS"   runat="server" />
    </div>
</asp:Content>