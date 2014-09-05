﻿
<%@ Page Title="办公用品领用" Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="PIC.Biz.Web.OfficeSupply.List" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadHolder" runat="server">

<script type="text/javascript" src="/portal/js/pgctrl-ext4-3rd.js"></script>
<script type="text/javascript" src="/portal/js/pgctrl-ext4.js"></script>
<script type="text/javascript" src="/portal/js/pgctrl-ext4-form.js"></script>
<script type="text/javascript" src="/portal/js/pgctrl-ext4-grid.js"></script>
<script type="text/javascript" src="/portal/js/pgfunc-ext4.js"></script>
<script type="text/javascript" src="./js/List.js"></script>

<script type="text/javascript">

    function onPgLoad() {
        setPgUI();
    }

    function setPgUI() {
        // 页面视图
        viewport = Ext.create('PIC.ExtViewport', {
            layout: 'border',
            items: { xtype: 'picofficesupplygridpanel' }
        });
    }
    
    </script>

</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyHolder" runat="server">

</asp:Content>

