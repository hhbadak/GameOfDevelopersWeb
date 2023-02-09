<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UyeListele.aspx.cs" Inherits="GameOfDevelopersBlog.AdminPanel.UyeListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Üye Listesi</h3>
    <div>
        <asp:ListView ID="lv_uyeler" runat="server" OnItemCommand="lv_uyeler_ItemCommand">
            <LayoutTemplate>
                <table class="tablo" cellpadding="0" cellspacing="0">
                    <thead>
                        <tr>
                            <th>Üye No</th>
                            <th>İsim</th>
                            <th>Soyisim</th>
                            <th>Kullanıcı Adı</th>
                            <th>E-Mail</th>
                            <th>Durum</th>
                            <th>Seçenekler</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("isim") %></td>
                    <td><%#Eval("soyisim") %></td>
                    <td><%#Eval("kullaniciAdi") %></td>
                    <td><%#Eval("mail") %></td>
                    <td><%#Eval("durumStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_ban" runat="server" CssClass="sil" CommandName="aski" CommandArgument='<%#Eval("ID") %>'>Askıya Al</asp:LinkButton>
                        <asp:LinkButton ID="lbtn_aktif" runat="server" CssClass="duzenle" CommandName="askiKaldir" CommandArgument='<%#Eval("ID") %>'>Askıdan Çıkart</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
