<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStudentID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtOR = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTransactionID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblDate = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPaymentAmount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtChange = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbMethod = New System.Windows.Forms.ComboBox()
        Me.printDocument = New System.Drawing.Printing.PrintDocument()
        Me.printingFontSmall = New System.Windows.Forms.Label()
        Me.printingFontHead2 = New System.Windows.Forms.Label()
        Me.printingFontHead = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtRB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 67)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of Students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 23)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(475, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(63, 205)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(108, 16)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "Transaction ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.Enabled = False
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStudentID.HintForeColor = System.Drawing.Color.Empty
        Me.txtStudentID.HintText = ""
        Me.txtStudentID.isPassword = False
        Me.txtStudentID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtStudentID.LineIdleColor = System.Drawing.Color.Black
        Me.txtStudentID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtStudentID.LineThickness = 2
        Me.txtStudentID.Location = New System.Drawing.Point(275, 157)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(186, 42)
        Me.txtStudentID.TabIndex = 16
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(196, 268)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(87, 16)
        Me.BunifuCustomLabel2.TabIndex = 21
        Me.BunifuCustomLabel2.Text = "OR Number"
        '
        'txtOR
        '
        Me.txtOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtOR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOR.HintForeColor = System.Drawing.Color.Empty
        Me.txtOR.HintText = ""
        Me.txtOR.isPassword = False
        Me.txtOR.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtOR.LineIdleColor = System.Drawing.Color.Black
        Me.txtOR.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtOR.LineThickness = 2
        Me.txtOR.Location = New System.Drawing.Point(114, 222)
        Me.txtOR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(257, 42)
        Me.txtOR.TabIndex = 20
        Me.txtOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(328, 205)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(78, 16)
        Me.BunifuCustomLabel3.TabIndex = 23
        Me.BunifuCustomLabel3.Text = "Student ID"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTransactionID.Enabled = False
        Me.txtTransactionID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTransactionID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTransactionID.HintForeColor = System.Drawing.Color.Empty
        Me.txtTransactionID.HintText = ""
        Me.txtTransactionID.isPassword = False
        Me.txtTransactionID.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtTransactionID.LineIdleColor = System.Drawing.Color.Black
        Me.txtTransactionID.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtTransactionID.LineThickness = 2
        Me.txtTransactionID.Location = New System.Drawing.Point(28, 159)
        Me.txtTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(186, 42)
        Me.txtTransactionID.TabIndex = 22
        Me.txtTransactionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(25, 119)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(44, 16)
        Me.BunifuCustomLabel4.TabIndex = 26
        Me.BunifuCustomLabel4.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(75, 119)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 16)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "Date:"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(180, 345)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(122, 16)
        Me.BunifuCustomLabel5.TabIndex = 28
        Me.BunifuCustomLabel5.Text = "Payment Method"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(59, 473)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(122, 16)
        Me.BunifuCustomLabel6.TabIndex = 30
        Me.BunifuCustomLabel6.Text = "Payment Amount"
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaymentAmount.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPaymentAmount.HintForeColor = System.Drawing.Color.Empty
        Me.txtPaymentAmount.HintText = ""
        Me.txtPaymentAmount.isPassword = False
        Me.txtPaymentAmount.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtPaymentAmount.LineIdleColor = System.Drawing.Color.Black
        Me.txtPaymentAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtPaymentAmount.LineThickness = 2
        Me.txtPaymentAmount.Location = New System.Drawing.Point(28, 430)
        Me.txtPaymentAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(186, 42)
        Me.txtPaymentAmount.TabIndex = 29
        Me.txtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(339, 476)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(60, 16)
        Me.BunifuCustomLabel7.TabIndex = 32
        Me.BunifuCustomLabel7.Text = "Change"
        '
        'txtChange
        '
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtChange.HintForeColor = System.Drawing.Color.Empty
        Me.txtChange.HintText = ""
        Me.txtChange.isPassword = False
        Me.txtChange.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtChange.LineIdleColor = System.Drawing.Color.Black
        Me.txtChange.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtChange.LineThickness = 2
        Me.txtChange.Location = New System.Drawing.Point(275, 430)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(186, 42)
        Me.txtChange.TabIndex = 31
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrint
        '
        Me.btnPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.BorderRadius = 0
        Me.btnPrint.ButtonText = "Process Payment"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrint.Iconimage = CType(resources.GetObject("btnPrint.Iconimage"), System.Drawing.Image)
        Me.btnPrint.Iconimage_right = Nothing
        Me.btnPrint.Iconimage_right_Selected = Nothing
        Me.btnPrint.Iconimage_Selected = Nothing
        Me.btnPrint.IconMarginLeft = 0
        Me.btnPrint.IconMarginRight = 0
        Me.btnPrint.IconRightVisible = True
        Me.btnPrint.IconRightZoom = 0R
        Me.btnPrint.IconVisible = True
        Me.btnPrint.IconZoom = 90.0R
        Me.btnPrint.IsTab = False
        Me.btnPrint.Location = New System.Drawing.Point(114, 516)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.Black
        Me.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(257, 38)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "Process Payment"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(86, 411)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(58, 16)
        Me.BunifuCustomLabel8.TabIndex = 35
        Me.BunifuCustomLabel8.Text = "Amount"
        '
        'txtFP
        '
        Me.txtFP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFP.Enabled = False
        Me.txtFP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFP.HintForeColor = System.Drawing.Color.Empty
        Me.txtFP.HintText = ""
        Me.txtFP.isPassword = False
        Me.txtFP.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFP.LineIdleColor = System.Drawing.Color.Black
        Me.txtFP.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFP.LineThickness = 2
        Me.txtFP.Location = New System.Drawing.Point(28, 365)
        Me.txtFP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFP.Name = "txtFP"
        Me.txtFP.Size = New System.Drawing.Size(186, 42)
        Me.txtFP.TabIndex = 34
        Me.txtFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbMethod
        '
        Me.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMethod.FormattingEnabled = True
        Me.cbMethod.Items.AddRange(New Object() {"Full Payment", "Installment", "Prelim", "Midterm", "Pre-Final", "Final"})
        Me.cbMethod.Location = New System.Drawing.Point(114, 317)
        Me.cbMethod.Name = "cbMethod"
        Me.cbMethod.Size = New System.Drawing.Size(257, 24)
        Me.cbMethod.TabIndex = 36
        '
        'printDocument
        '
        '
        'printingFontSmall
        '
        Me.printingFontSmall.AutoSize = True
        Me.printingFontSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printingFontSmall.Location = New System.Drawing.Point(407, 344)
        Me.printingFontSmall.Name = "printingFontSmall"
        Me.printingFontSmall.Size = New System.Drawing.Size(33, 16)
        Me.printingFontSmall.TabIndex = 84
        Me.printingFontSmall.Text = "Font"
        Me.printingFontSmall.Visible = False
        '
        'printingFontHead2
        '
        Me.printingFontHead2.AutoSize = True
        Me.printingFontHead2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printingFontHead2.Location = New System.Drawing.Point(406, 321)
        Me.printingFontHead2.Name = "printingFontHead2"
        Me.printingFontHead2.Size = New System.Drawing.Size(42, 20)
        Me.printingFontHead2.TabIndex = 83
        Me.printingFontHead2.Text = "Font"
        Me.printingFontHead2.Visible = False
        '
        'printingFontHead
        '
        Me.printingFontHead.AutoSize = True
        Me.printingFontHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printingFontHead.Location = New System.Drawing.Point(403, 285)
        Me.printingFontHead.Name = "printingFontHead"
        Me.printingFontHead.Size = New System.Drawing.Size(82, 37)
        Me.printingFontHead.TabIndex = 82
        Me.printingFontHead.Text = "Font"
        Me.printingFontHead.Visible = False
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'Timer1
        '
        '
        'txtRB
        '
        Me.txtRB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRB.Enabled = False
        Me.txtRB.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRB.HintForeColor = System.Drawing.Color.Empty
        Me.txtRB.HintText = ""
        Me.txtRB.isPassword = False
        Me.txtRB.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtRB.LineIdleColor = System.Drawing.Color.Black
        Me.txtRB.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtRB.LineThickness = 2
        Me.txtRB.Location = New System.Drawing.Point(275, 365)
        Me.txtRB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRB.Name = "txtRB"
        Me.txtRB.Size = New System.Drawing.Size(186, 42)
        Me.txtRB.TabIndex = 85
        Me.txtRB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(298, 411)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(142, 16)
        Me.BunifuCustomLabel9.TabIndex = 86
        Me.BunifuCustomLabel9.Text = "Remaining Balance"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 566)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.txtRB)
        Me.Controls.Add(Me.printingFontSmall)
        Me.Controls.Add(Me.printingFontHead2)
        Me.Controls.Add(Me.printingFontHead)
        Me.Controls.Add(Me.cbMethod)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.txtFP)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.txtPaymentAmount)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.txtTransactionID)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtOR)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtStudentID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtOR As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTransactionID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDate As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPaymentAmount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtChange As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbMethod As ComboBox
    Friend WithEvents printDocument As Printing.PrintDocument
    Friend WithEvents printingFontSmall As Label
    Friend WithEvents printingFontHead2 As Label
    Friend WithEvents printingFontHead As Label
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtRB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
