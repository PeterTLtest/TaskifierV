﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUiMockup
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.scTabsAndMain = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.scTagsAndLogEntries = New System.Windows.Forms.SplitContainer()
        Me.dgvTags = New System.Windows.Forms.DataGridView()
        Me.scLogEntriesAndDetails = New System.Windows.Forms.SplitContainer()
        Me.dgvLogEntries = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblInProgress = New System.Windows.Forms.Label()
        Me.lblFinished = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPriority = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtInProgress = New System.Windows.Forms.TextBox()
        Me.txtFinished = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtActive = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtLogType = New System.Windows.Forms.TextBox()
        Me.lblLogType = New System.Windows.Forms.Label()
        Me.lblActive = New System.Windows.Forms.Label()
        CType(Me.scTabsAndMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTabsAndMain.Panel1.SuspendLayout()
        Me.scTabsAndMain.Panel2.SuspendLayout()
        Me.scTabsAndMain.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.scTagsAndLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTagsAndLogEntries.Panel1.SuspendLayout()
        Me.scTagsAndLogEntries.Panel2.SuspendLayout()
        Me.scTagsAndLogEntries.SuspendLayout()
        CType(Me.dgvTags, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scLogEntriesAndDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scLogEntriesAndDetails.Panel1.SuspendLayout()
        Me.scLogEntriesAndDetails.Panel2.SuspendLayout()
        Me.scLogEntriesAndDetails.SuspendLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scTabsAndMain
        '
        Me.scTabsAndMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scTabsAndMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTabsAndMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scTabsAndMain.IsSplitterFixed = True
        Me.scTabsAndMain.Location = New System.Drawing.Point(0, 0)
        Me.scTabsAndMain.Name = "scTabsAndMain"
        '
        'scTabsAndMain.Panel1
        '
        Me.scTabsAndMain.Panel1.Controls.Add(Me.TabControl1)
        '
        'scTabsAndMain.Panel2
        '
        Me.scTabsAndMain.Panel2.Controls.Add(Me.scTagsAndLogEntries)
        Me.scTabsAndMain.Size = New System.Drawing.Size(759, 280)
        Me.scTabsAndMain.SplitterDistance = 89
        Me.scTabsAndMain.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 80)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(83, 256)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(100, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(0, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Backlog"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(100, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(0, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Worklog"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(100, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(0, 248)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Donelog"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'scTagsAndLogEntries
        '
        Me.scTagsAndLogEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scTagsAndLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTagsAndLogEntries.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scTagsAndLogEntries.IsSplitterFixed = True
        Me.scTagsAndLogEntries.Location = New System.Drawing.Point(0, 0)
        Me.scTagsAndLogEntries.Name = "scTagsAndLogEntries"
        '
        'scTagsAndLogEntries.Panel1
        '
        Me.scTagsAndLogEntries.Panel1.Controls.Add(Me.dgvTags)
        '
        'scTagsAndLogEntries.Panel2
        '
        Me.scTagsAndLogEntries.Panel2.Controls.Add(Me.scLogEntriesAndDetails)
        Me.scTagsAndLogEntries.Size = New System.Drawing.Size(666, 280)
        Me.scTagsAndLogEntries.SplitterDistance = 144
        Me.scTagsAndLogEntries.TabIndex = 0
        '
        'dgvTags
        '
        Me.dgvTags.AllowUserToAddRows = False
        Me.dgvTags.AllowUserToDeleteRows = False
        Me.dgvTags.AllowUserToOrderColumns = True
        Me.dgvTags.AllowUserToResizeColumns = False
        Me.dgvTags.AllowUserToResizeRows = False
        Me.dgvTags.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTags.ColumnHeadersVisible = False
        Me.dgvTags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTags.Location = New System.Drawing.Point(0, 0)
        Me.dgvTags.MultiSelect = False
        Me.dgvTags.Name = "dgvTags"
        Me.dgvTags.ReadOnly = True
        Me.dgvTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTags.Size = New System.Drawing.Size(142, 278)
        Me.dgvTags.TabIndex = 0
        '
        'scLogEntriesAndDetails
        '
        Me.scLogEntriesAndDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scLogEntriesAndDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scLogEntriesAndDetails.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scLogEntriesAndDetails.IsSplitterFixed = True
        Me.scLogEntriesAndDetails.Location = New System.Drawing.Point(0, 0)
        Me.scLogEntriesAndDetails.Name = "scLogEntriesAndDetails"
        '
        'scLogEntriesAndDetails.Panel1
        '
        Me.scLogEntriesAndDetails.Panel1.Controls.Add(Me.dgvLogEntries)
        '
        'scLogEntriesAndDetails.Panel2
        '
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblActive)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblLogType)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtLogType)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblId)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtActive)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtId)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtFinished)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtInProgress)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtEndDate)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtStartDate)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtPriority)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtDescription)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.txtName)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblFinished)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblInProgress)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblEndDate)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblStartDate)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblPriority)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblDescription)
        Me.scLogEntriesAndDetails.Panel2.Controls.Add(Me.lblName)
        Me.scLogEntriesAndDetails.Size = New System.Drawing.Size(518, 280)
        Me.scLogEntriesAndDetails.SplitterDistance = 188
        Me.scLogEntriesAndDetails.TabIndex = 0
        '
        'dgvLogEntries
        '
        Me.dgvLogEntries.AllowUserToAddRows = False
        Me.dgvLogEntries.AllowUserToDeleteRows = False
        Me.dgvLogEntries.AllowUserToOrderColumns = True
        Me.dgvLogEntries.AllowUserToResizeColumns = False
        Me.dgvLogEntries.AllowUserToResizeRows = False
        Me.dgvLogEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogEntries.ColumnHeadersVisible = False
        Me.dgvLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogEntries.Location = New System.Drawing.Point(0, 0)
        Me.dgvLogEntries.MultiSelect = False
        Me.dgvLogEntries.Name = "dgvLogEntries"
        Me.dgvLogEntries.ReadOnly = True
        Me.dgvLogEntries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLogEntries.Size = New System.Drawing.Size(186, 278)
        Me.dgvLogEntries.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(42, 66)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(17, 92)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Description:"
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Location = New System.Drawing.Point(39, 118)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(41, 13)
        Me.lblPriority.TabIndex = 2
        Me.lblPriority.Text = "Priority:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(22, 144)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(58, 13)
        Me.lblStartDate.TabIndex = 3
        Me.lblStartDate.Text = "Start Date:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(25, 170)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 13)
        Me.lblEndDate.TabIndex = 4
        Me.lblEndDate.Text = "End Date:"
        '
        'lblInProgress
        '
        Me.lblInProgress.AutoSize = True
        Me.lblInProgress.Location = New System.Drawing.Point(17, 222)
        Me.lblInProgress.Name = "lblInProgress"
        Me.lblInProgress.Size = New System.Drawing.Size(63, 13)
        Me.lblInProgress.TabIndex = 5
        Me.lblInProgress.Text = "In Progress:"
        '
        'lblFinished
        '
        Me.lblFinished.AutoSize = True
        Me.lblFinished.Location = New System.Drawing.Point(31, 248)
        Me.lblFinished.Name = "lblFinished"
        Me.lblFinished.Size = New System.Drawing.Size(49, 13)
        Me.lblFinished.TabIndex = 6
        Me.lblFinished.Text = "Finished:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(86, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 20)
        Me.txtName.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(86, 89)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(227, 20)
        Me.txtDescription.TabIndex = 8
        '
        'txtPriority
        '
        Me.txtPriority.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPriority.Location = New System.Drawing.Point(86, 115)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(227, 20)
        Me.txtPriority.TabIndex = 9
        '
        'txtStartDate
        '
        Me.txtStartDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStartDate.Location = New System.Drawing.Point(86, 141)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(227, 20)
        Me.txtStartDate.TabIndex = 10
        '
        'txtEndDate
        '
        Me.txtEndDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEndDate.Location = New System.Drawing.Point(86, 167)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(227, 20)
        Me.txtEndDate.TabIndex = 11
        '
        'txtInProgress
        '
        Me.txtInProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInProgress.Location = New System.Drawing.Point(86, 219)
        Me.txtInProgress.Name = "txtInProgress"
        Me.txtInProgress.Size = New System.Drawing.Size(227, 20)
        Me.txtInProgress.TabIndex = 12
        '
        'txtFinished
        '
        Me.txtFinished.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFinished.Location = New System.Drawing.Point(86, 245)
        Me.txtFinished.Name = "txtFinished"
        Me.txtFinished.Size = New System.Drawing.Size(227, 20)
        Me.txtFinished.TabIndex = 13
        '
        'txtId
        '
        Me.txtId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtId.Location = New System.Drawing.Point(86, 11)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(227, 20)
        Me.txtId.TabIndex = 14
        '
        'txtActive
        '
        Me.txtActive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtActive.Location = New System.Drawing.Point(86, 193)
        Me.txtActive.Name = "txtActive"
        Me.txtActive.Size = New System.Drawing.Size(227, 20)
        Me.txtActive.TabIndex = 15
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(61, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 13)
        Me.lblId.TabIndex = 17
        Me.lblId.Text = "Id:"
        '
        'txtLogType
        '
        Me.txtLogType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogType.Location = New System.Drawing.Point(86, 37)
        Me.txtLogType.Name = "txtLogType"
        Me.txtLogType.Size = New System.Drawing.Size(227, 20)
        Me.txtLogType.TabIndex = 18
        '
        'lblLogType
        '
        Me.lblLogType.AutoSize = True
        Me.lblLogType.Location = New System.Drawing.Point(25, 40)
        Me.lblLogType.Name = "lblLogType"
        Me.lblLogType.Size = New System.Drawing.Size(55, 13)
        Me.lblLogType.TabIndex = 19
        Me.lblLogType.Text = "Log Type:"
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Location = New System.Drawing.Point(39, 196)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(40, 13)
        Me.lblActive.TabIndex = 20
        Me.lblActive.Text = "Active:"
        '
        'frmUiMockup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 280)
        Me.Controls.Add(Me.scTabsAndMain)
        Me.MinimumSize = New System.Drawing.Size(725, 300)
        Me.Name = "frmUiMockup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUiMockup"
        Me.scTabsAndMain.Panel1.ResumeLayout(False)
        Me.scTabsAndMain.Panel2.ResumeLayout(False)
        CType(Me.scTabsAndMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTabsAndMain.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.scTagsAndLogEntries.Panel1.ResumeLayout(False)
        Me.scTagsAndLogEntries.Panel2.ResumeLayout(False)
        CType(Me.scTagsAndLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTagsAndLogEntries.ResumeLayout(False)
        CType(Me.dgvTags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scLogEntriesAndDetails.Panel1.ResumeLayout(False)
        Me.scLogEntriesAndDetails.Panel2.ResumeLayout(False)
        Me.scLogEntriesAndDetails.Panel2.PerformLayout()
        CType(Me.scLogEntriesAndDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scLogEntriesAndDetails.ResumeLayout(False)
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scTabsAndMain As System.Windows.Forms.SplitContainer
    Friend WithEvents scTagsAndLogEntries As System.Windows.Forms.SplitContainer
    Friend WithEvents scLogEntriesAndDetails As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvTags As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvLogEntries As System.Windows.Forms.DataGridView
    Friend WithEvents lblActive As System.Windows.Forms.Label
    Friend WithEvents lblLogType As System.Windows.Forms.Label
    Friend WithEvents txtLogType As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtActive As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtFinished As System.Windows.Forms.TextBox
    Friend WithEvents txtInProgress As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPriority As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblFinished As System.Windows.Forms.Label
    Friend WithEvents lblInProgress As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
