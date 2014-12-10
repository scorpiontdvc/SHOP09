<%@ Page Title="" Language="C#" MasterPageFile="~/ad/AdminMaster.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="ad_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1 class="page-header">Quan ly chuyen muc</h1>

    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading" style="">
                    Them Chuyen Muc
                </div>
                <div class="form-group" style="margin-left: 30px">
                    <label>Ten Chuyen Muc</label>
                    <asp:TextBox ID="txt_cateName" runat="server" CssClass="form-control" Style="width: 300px;" OnTextChanged="txt_cateName_TextChanged"></asp:TextBox>
                </div>
                <div class="form-group" style="margin-left: 30px">
                    <label>Chuyen Muc Cha</label>
                    <br />
                    <asp:DropDownList ID="dropListParent" class="form-control" Width="300" runat="server" ForeColor="Black" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>AAAAAA</asp:ListItem>
                        <asp:ListItem>BBBBB</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group" style="margin-left: 30px">
                    <label>Url</label>
                    <asp:TextBox ID="txt_url" class="form-control" Style="width: 300px;" runat="server"></asp:TextBox>

                </div>
                <div class="form-group" style="margin-left: 30px">
                    <label>Thu tu</label>
                    <asp:TextBox ID="txt_index" class="form-control" runat="server" Style="width: 100px;"></asp:TextBox>
                </div>
                <button type="button" class="btn btn-success">Thêm Chuyên Mục</button>

                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="757px">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>



</asp:Content>

