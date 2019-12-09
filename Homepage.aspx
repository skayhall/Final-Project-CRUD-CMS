<%@ Page Title="Pages CMS" Language="C#" MasterPageFile="~/Layout.Master" 
    AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" 
    Inherits="FinalProject_PagesCMS.Homepage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="body" runat="server">
    <h2><%: Title %></h2>
    <h3>Welcome to the Pages CMS</h3>
    <img src="content/images/main_header.jpg"/>
    <p>You have ___ pages in total.</p>
</asp:Content>

