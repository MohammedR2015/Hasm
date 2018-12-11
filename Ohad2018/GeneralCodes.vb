Imports System.Data.OleDb

Public Class GeneralCodes
    Public conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0; DATA SOURCE=D:\HikmaP\OhdaDatabase\Hikma.ACCDB;JET OLEDB:Database PASSWORD=123abcking-")
    Public CustodyTable As String = " select * from Custody"
    Public CustodyDetails As String = " select * from Details" 'ComIDcustody
    Public Docu As String = " select * from Douc"
    Public x As String = " select * from t"


    Public Mach As String = " select * from Mach"



    Public Adapter As New OleDbDataAdapter
    '''------------------------------------------------Insert/Delete/Update --------------------------
    Public SaveCode As String
    Public TypeOfProsses As String
    Public Sub SaverDB()
        Try
            Dim value As MsgBoxResult = MsgBox("؟هل تريد تنفيذ هذة العملية  ", MsgBoxStyle.YesNo + MessageBoxOptions.RightAlign, "تحــــــــــذير")
            If value = MsgBoxResult.Yes Then
                Dim savinto As New OleDb.OleDbCommand
                savinto.Connection = conn
                savinto.CommandType = CommandType.Text
                savinto.CommandText = SaveCode
                conn.Open()
                savinto.ExecuteNonQuery()
                conn.Close()
                MsgBox("لقد تمة عملية " & TypeOfProsses & " بنجاح ", MsgBoxStyle.Information + MessageBoxOptions.RightAlign, "تنبية")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub
    ''------------------------------------------- End Ther -----------------------------


End Class
