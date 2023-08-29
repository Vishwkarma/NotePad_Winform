<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem1 = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem2 = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        AlignToolStripMenuItem = New ToolStripMenuItem()
        LeftToolStripMenuItem = New ToolStripMenuItem()
        RightToolStripMenuItem = New ToolStripMenuItem()
        CenterToolStripMenuItem = New ToolStripMenuItem()
        BulleteToolStripMenuItem = New ToolStripMenuItem()
        YesToolStripMenuItem = New ToolStripMenuItem()
        NoToolStripMenuItem = New ToolStripMenuItem()
        ZoomToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ZoomToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, SaveToolStripMenuItem, OpenToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(128, 26)
        NewToolStripMenuItem.Text = "New "
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(128, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(128, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(128, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EditToolStripMenuItem1, UndoToolStripMenuItem, RedoToolStripMenuItem, PasteToolStripMenuItem, EditToolStripMenuItem2})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' EditToolStripMenuItem1
        ' 
        EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        EditToolStripMenuItem1.Size = New Size(128, 26)
        EditToolStripMenuItem1.Text = "Copy"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(128, 26)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.Size = New Size(128, 26)
        RedoToolStripMenuItem.Text = "Redo"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(128, 26)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' EditToolStripMenuItem2
        ' 
        EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        EditToolStripMenuItem2.Size = New Size(128, 26)
        EditToolStripMenuItem2.Text = "Edit"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontToolStripMenuItem, ColorToolStripMenuItem, AlignToolStripMenuItem, BulleteToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(70, 24)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(138, 26)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(138, 26)
        ColorToolStripMenuItem.Text = "Color"
        ' 
        ' AlignToolStripMenuItem
        ' 
        AlignToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeftToolStripMenuItem, RightToolStripMenuItem, CenterToolStripMenuItem})
        AlignToolStripMenuItem.Name = "AlignToolStripMenuItem"
        AlignToolStripMenuItem.Size = New Size(138, 26)
        AlignToolStripMenuItem.Text = "Align"
        ' 
        ' LeftToolStripMenuItem
        ' 
        LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        LeftToolStripMenuItem.Size = New Size(135, 26)
        LeftToolStripMenuItem.Text = "Left"
        ' 
        ' RightToolStripMenuItem
        ' 
        RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        RightToolStripMenuItem.Size = New Size(135, 26)
        RightToolStripMenuItem.Text = "Right"
        ' 
        ' CenterToolStripMenuItem
        ' 
        CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        CenterToolStripMenuItem.Size = New Size(135, 26)
        CenterToolStripMenuItem.Text = "Center"
        ' 
        ' BulleteToolStripMenuItem
        ' 
        BulleteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {YesToolStripMenuItem, NoToolStripMenuItem})
        BulleteToolStripMenuItem.Name = "BulleteToolStripMenuItem"
        BulleteToolStripMenuItem.Size = New Size(138, 26)
        BulleteToolStripMenuItem.Text = "Bullete"
        ' 
        ' YesToolStripMenuItem
        ' 
        YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        YesToolStripMenuItem.Size = New Size(113, 26)
        YesToolStripMenuItem.Text = "Yes"
        ' 
        ' NoToolStripMenuItem
        ' 
        NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        NoToolStripMenuItem.Size = New Size(113, 26)
        NoToolStripMenuItem.Text = "No"
        ' 
        ' ZoomToolStripMenuItem
        ' 
        ZoomToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5})
        ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        ZoomToolStripMenuItem.Size = New Size(63, 24)
        ZoomToolStripMenuItem.Text = "Zoom"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(224, 26)
        ToolStripMenuItem2.Text = "2"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(224, 26)
        ToolStripMenuItem3.Text = "4"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(224, 26)
        ToolStripMenuItem4.Text = "6"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(224, 26)
        ToolStripMenuItem5.Text = "10"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(0, 28)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(800, 422)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Notepad"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
