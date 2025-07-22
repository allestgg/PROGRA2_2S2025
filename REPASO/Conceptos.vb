' VB.NET - Guía de Sintaxis y Conceptos Básicos

'--- Comentarios ---
' Esto es un comentario de una sola línea

'--- Declaración de variables ---
Dim numero As Integer = 10
Dim nombre As String = "Juan"
Dim activo As Boolean = True
Dim pi As Double = 3.14

'--- Estructuras de control ---

' If / ElseIf / Else
If numero > 0 Then
    MsgBox("Positivo")
ElseIf numero = 0 Then
    MsgBox("Cero")
Else
    MsgBox("Negativo")
End If

' Operador ternario (If inline)
Dim resultado As String = If(numero > 0, "Mayor que cero", "No es mayor")

' Select Case
Select Case numero
    Case 1
        MsgBox("Uno")
    Case 2 To 5
        MsgBox("Entre 2 y 5")
    Case Else
        MsgBox("Otro")
End Select

' For loop
For i As Integer = 1 To 5
    MsgBox("Valor: " & i)
Next

' While loop
Dim contador As Integer = 0
While contador < 3
    MsgBox("Contador: " & contador)
    contador += 1
End While

'--- Funciones y Subrutinas ---

' Subrutina sin retorno
Sub Saludar()
    MsgBox("Hola")
End Sub

' Función con retorno
Function Sumar(a As Integer, b As Integer) As Integer
    Return a + b
End Function

'--- Manejo de controles básicos ---

' Cambiar texto en un Label
Label1.Text = "Nuevo texto"

' Leer texto desde un TextBox
Dim texto As String = TextBox1.Text

' Cambiar color de fondo en un Panel
Panel1.BackColor = Color.Blue

' Agregar elementos a CheckedListBox
CheckedListBox1.Items.Add("Opcion 1")

' Obtener seleccionados y concatenar
Dim seleccionados As String = ""
For Each item As String In CheckedListBox1.CheckedItems
    seleccionados &= item & ", "
Next
If seleccionados.Length > 0 Then
    seleccionados = seleccionados.Substring(0, seleccionados.Length - 2)
End If

' Usar RadioButtons (2 opciones + sin selección)
Dim genero As String = If(RadioButton1.Checked, "Masculino", _
                    If(RadioButton2.Checked, "Femenino", "No ha seleccionado género"))

'--- Manejo de errores ---
Try
    Dim division As Double = 10 / 0
Catch ex As Exception
    MsgBox("Error: " & ex.Message)
End Try

'--- Arrays y Listas ---
Dim numeros() As Integer = {1, 2, 3}
Dim lista As New List(Of String)
lista.Add("A")
lista.Add("B")

'--- MessageBox / MsgBox ---
MsgBox("Esto es un mensaje", MsgBoxStyle.Information, "Título")

'--- Final ---
' Puedes usar este archivo como referencia rápida de sintaxis y estructuras comunes en VB.NET.
