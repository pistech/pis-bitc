﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlowSelect.aspx.cs" Inherits="PIC.Portal.Web.Modules.Common.Bpm.FlowSelect" %>
<%@ OutputCache Duration="1" VaryByParam="None" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadHolder" runat="server">
    
<script type="text/javascript">

    function onPgLoad() {

        Ext.create('PIC.view.com.bpm.FlowSelector');

    }
    
 </script>

</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyHolder" runat="server">
</asp:Content>