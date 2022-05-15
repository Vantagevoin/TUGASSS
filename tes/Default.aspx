<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2">
                        <h1>Insertion/Updation</h1>
                    </td>
                </tr>
                <tr>
                    <td>Employee ID</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee First Name</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtEmpFname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Last Name</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtEmpLname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee Email-ID</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtEmpEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:Button ID="btnInsertion" runat="server" Text="Insert" OnClick="btnInsertion_Click"  />
                        <asp:Button ID="btnUpdation" runat="server" Text="Update" OnClick="btnUpdation_Click"  />
                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>

            <hr />

            <table>
                <tr>
                    <td>
                        <h1>Selection</h1>
                    </td>
                </tr>
                <tr>

                    <td>
                        <asp:Button ID="btnSelect" runat="server" Text="Select All Data" OnClick="btnSelect_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </td>
                </tr>
            </table>
            <hr />
            
            <hr />

            <table>
                <tr>
                    <td colspan="3">
                        <h1>Deletion</h1>
                    </td>
                </tr> <tr>
                    <td>Employee ID</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr >

                    <td colspan="3">
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>

                    </td>
                </tr>
                
            </table>

        </div>
    </form>
</body>
</html>
