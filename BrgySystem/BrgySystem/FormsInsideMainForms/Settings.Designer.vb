﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.MainPanelSetting = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BarangayDetailsButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.AccountSettingsButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.MissionVisionzButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.OrganizationChart = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
        '
        'MainPanelSetting
        '
        Me.MainPanelSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanelSetting.AutoSize = True
        Me.MainPanelSetting.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MainPanelSetting.BackgroundImage = CType(resources.GetObject("MainPanelSetting.BackgroundImage"), System.Drawing.Image)
        Me.MainPanelSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanelSetting.BorderColor = System.Drawing.Color.Transparent
        Me.MainPanelSetting.BorderRadius = 3
        Me.MainPanelSetting.BorderThickness = 1
        Me.MainPanelSetting.Location = New System.Drawing.Point(-1, 119)
        Me.MainPanelSetting.Name = "MainPanelSetting"
        Me.MainPanelSetting.ShowBorders = True
        Me.MainPanelSetting.Size = New System.Drawing.Size(1127, 647)
        Me.MainPanelSetting.TabIndex = 2
        '
        'BarangayDetailsButton
        '
        Me.BarangayDetailsButton.AllowAnimations = True
        Me.BarangayDetailsButton.AllowMouseEffects = True
        Me.BarangayDetailsButton.AllowToggling = False
        Me.BarangayDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BarangayDetailsButton.AnimationSpeed = 200
        Me.BarangayDetailsButton.AutoGenerateColors = False
        Me.BarangayDetailsButton.AutoRoundBorders = True
        Me.BarangayDetailsButton.AutoSizeLeftIcon = True
        Me.BarangayDetailsButton.AutoSizeRightIcon = True
        Me.BarangayDetailsButton.BackColor = System.Drawing.Color.Transparent
        Me.BarangayDetailsButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BarangayDetailsButton.BackgroundImage = CType(resources.GetObject("BarangayDetailsButton.BackgroundImage"), System.Drawing.Image)
        Me.BarangayDetailsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BarangayDetailsButton.ButtonText = "Barangay Details"
        Me.BarangayDetailsButton.ButtonTextMarginLeft = 0
        Me.BarangayDetailsButton.ColorContrastOnClick = 45
        Me.BarangayDetailsButton.ColorContrastOnHover = 45
        Me.BarangayDetailsButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BarangayDetailsButton.CustomizableEdges = BorderEdges1
        Me.BarangayDetailsButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BarangayDetailsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BarangayDetailsButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BarangayDetailsButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BarangayDetailsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BarangayDetailsButton.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangayDetailsButton.ForeColor = System.Drawing.Color.White
        Me.BarangayDetailsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BarangayDetailsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BarangayDetailsButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BarangayDetailsButton.IconMarginLeft = 11
        Me.BarangayDetailsButton.IconPadding = 10
        Me.BarangayDetailsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BarangayDetailsButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BarangayDetailsButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BarangayDetailsButton.IconSize = 25
        Me.BarangayDetailsButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BarangayDetailsButton.IdleBorderRadius = 44
        Me.BarangayDetailsButton.IdleBorderThickness = 1
        Me.BarangayDetailsButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BarangayDetailsButton.IdleIconLeftImage = Nothing
        Me.BarangayDetailsButton.IdleIconRightImage = Nothing
        Me.BarangayDetailsButton.IndicateFocus = False
        Me.BarangayDetailsButton.Location = New System.Drawing.Point(302, 67)
        Me.BarangayDetailsButton.Name = "BarangayDetailsButton"
        Me.BarangayDetailsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BarangayDetailsButton.OnDisabledState.BorderRadius = 40
        Me.BarangayDetailsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BarangayDetailsButton.OnDisabledState.BorderThickness = 1
        Me.BarangayDetailsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BarangayDetailsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BarangayDetailsButton.OnDisabledState.IconLeftImage = Nothing
        Me.BarangayDetailsButton.OnDisabledState.IconRightImage = Nothing
        Me.BarangayDetailsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarangayDetailsButton.onHoverState.BorderRadius = 40
        Me.BarangayDetailsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BarangayDetailsButton.onHoverState.BorderThickness = 1
        Me.BarangayDetailsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarangayDetailsButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BarangayDetailsButton.onHoverState.IconLeftImage = Nothing
        Me.BarangayDetailsButton.onHoverState.IconRightImage = Nothing
        Me.BarangayDetailsButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BarangayDetailsButton.OnIdleState.BorderRadius = 40
        Me.BarangayDetailsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BarangayDetailsButton.OnIdleState.BorderThickness = 1
        Me.BarangayDetailsButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BarangayDetailsButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BarangayDetailsButton.OnIdleState.IconLeftImage = Nothing
        Me.BarangayDetailsButton.OnIdleState.IconRightImage = Nothing
        Me.BarangayDetailsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BarangayDetailsButton.OnPressedState.BorderRadius = 40
        Me.BarangayDetailsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BarangayDetailsButton.OnPressedState.BorderThickness = 1
        Me.BarangayDetailsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BarangayDetailsButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BarangayDetailsButton.OnPressedState.IconLeftImage = Nothing
        Me.BarangayDetailsButton.OnPressedState.IconRightImage = Nothing
        Me.BarangayDetailsButton.Size = New System.Drawing.Size(254, 46)
        Me.BarangayDetailsButton.TabIndex = 6
        Me.BarangayDetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BarangayDetailsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BarangayDetailsButton.TextMarginLeft = 0
        Me.BarangayDetailsButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BarangayDetailsButton.UseDefaultRadiusAndThickness = True
        '
        'AccountSettingsButton
        '
        Me.AccountSettingsButton.AllowAnimations = True
        Me.AccountSettingsButton.AllowMouseEffects = True
        Me.AccountSettingsButton.AllowToggling = False
        Me.AccountSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AccountSettingsButton.AnimationSpeed = 200
        Me.AccountSettingsButton.AutoGenerateColors = False
        Me.AccountSettingsButton.AutoRoundBorders = True
        Me.AccountSettingsButton.AutoSizeLeftIcon = True
        Me.AccountSettingsButton.AutoSizeRightIcon = True
        Me.AccountSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.AccountSettingsButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AccountSettingsButton.BackgroundImage = CType(resources.GetObject("AccountSettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.AccountSettingsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AccountSettingsButton.ButtonText = "Account Settings"
        Me.AccountSettingsButton.ButtonTextMarginLeft = 0
        Me.AccountSettingsButton.ColorContrastOnClick = 45
        Me.AccountSettingsButton.ColorContrastOnHover = 45
        Me.AccountSettingsButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.AccountSettingsButton.CustomizableEdges = BorderEdges2
        Me.AccountSettingsButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AccountSettingsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AccountSettingsButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AccountSettingsButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AccountSettingsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.AccountSettingsButton.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountSettingsButton.ForeColor = System.Drawing.Color.White
        Me.AccountSettingsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountSettingsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.AccountSettingsButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.AccountSettingsButton.IconMarginLeft = 11
        Me.AccountSettingsButton.IconPadding = 10
        Me.AccountSettingsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AccountSettingsButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.AccountSettingsButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.AccountSettingsButton.IconSize = 25
        Me.AccountSettingsButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.AccountSettingsButton.IdleBorderRadius = 44
        Me.AccountSettingsButton.IdleBorderThickness = 1
        Me.AccountSettingsButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AccountSettingsButton.IdleIconLeftImage = Nothing
        Me.AccountSettingsButton.IdleIconRightImage = Nothing
        Me.AccountSettingsButton.IndicateFocus = False
        Me.AccountSettingsButton.Location = New System.Drawing.Point(42, 67)
        Me.AccountSettingsButton.Name = "AccountSettingsButton"
        Me.AccountSettingsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AccountSettingsButton.OnDisabledState.BorderRadius = 40
        Me.AccountSettingsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AccountSettingsButton.OnDisabledState.BorderThickness = 1
        Me.AccountSettingsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AccountSettingsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AccountSettingsButton.OnDisabledState.IconLeftImage = Nothing
        Me.AccountSettingsButton.OnDisabledState.IconRightImage = Nothing
        Me.AccountSettingsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSettingsButton.onHoverState.BorderRadius = 40
        Me.AccountSettingsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AccountSettingsButton.onHoverState.BorderThickness = 1
        Me.AccountSettingsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountSettingsButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.AccountSettingsButton.onHoverState.IconLeftImage = Nothing
        Me.AccountSettingsButton.onHoverState.IconRightImage = Nothing
        Me.AccountSettingsButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.AccountSettingsButton.OnIdleState.BorderRadius = 40
        Me.AccountSettingsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AccountSettingsButton.OnIdleState.BorderThickness = 1
        Me.AccountSettingsButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AccountSettingsButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.AccountSettingsButton.OnIdleState.IconLeftImage = Nothing
        Me.AccountSettingsButton.OnIdleState.IconRightImage = Nothing
        Me.AccountSettingsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AccountSettingsButton.OnPressedState.BorderRadius = 40
        Me.AccountSettingsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AccountSettingsButton.OnPressedState.BorderThickness = 1
        Me.AccountSettingsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.AccountSettingsButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.AccountSettingsButton.OnPressedState.IconLeftImage = Nothing
        Me.AccountSettingsButton.OnPressedState.IconRightImage = Nothing
        Me.AccountSettingsButton.Size = New System.Drawing.Size(254, 46)
        Me.AccountSettingsButton.TabIndex = 0
        Me.AccountSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AccountSettingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.AccountSettingsButton.TextMarginLeft = 0
        Me.AccountSettingsButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.AccountSettingsButton.UseDefaultRadiusAndThickness = True
        '
        'MissionVisionzButton
        '
        Me.MissionVisionzButton.AllowAnimations = True
        Me.MissionVisionzButton.AllowMouseEffects = True
        Me.MissionVisionzButton.AllowToggling = False
        Me.MissionVisionzButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MissionVisionzButton.AnimationSpeed = 200
        Me.MissionVisionzButton.AutoGenerateColors = False
        Me.MissionVisionzButton.AutoRoundBorders = True
        Me.MissionVisionzButton.AutoSizeLeftIcon = True
        Me.MissionVisionzButton.AutoSizeRightIcon = True
        Me.MissionVisionzButton.BackColor = System.Drawing.Color.Transparent
        Me.MissionVisionzButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MissionVisionzButton.BackgroundImage = CType(resources.GetObject("MissionVisionzButton.BackgroundImage"), System.Drawing.Image)
        Me.MissionVisionzButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.MissionVisionzButton.ButtonText = "Mission/Vision"
        Me.MissionVisionzButton.ButtonTextMarginLeft = 0
        Me.MissionVisionzButton.ColorContrastOnClick = 45
        Me.MissionVisionzButton.ColorContrastOnHover = 45
        Me.MissionVisionzButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.MissionVisionzButton.CustomizableEdges = BorderEdges3
        Me.MissionVisionzButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.MissionVisionzButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MissionVisionzButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MissionVisionzButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.MissionVisionzButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.MissionVisionzButton.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MissionVisionzButton.ForeColor = System.Drawing.Color.White
        Me.MissionVisionzButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MissionVisionzButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.MissionVisionzButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.MissionVisionzButton.IconMarginLeft = 11
        Me.MissionVisionzButton.IconPadding = 10
        Me.MissionVisionzButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MissionVisionzButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.MissionVisionzButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.MissionVisionzButton.IconSize = 25
        Me.MissionVisionzButton.IdleBorderColor = System.Drawing.Color.Transparent
        Me.MissionVisionzButton.IdleBorderRadius = 44
        Me.MissionVisionzButton.IdleBorderThickness = 1
        Me.MissionVisionzButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MissionVisionzButton.IdleIconLeftImage = Nothing
        Me.MissionVisionzButton.IdleIconRightImage = Nothing
        Me.MissionVisionzButton.IndicateFocus = False
        Me.MissionVisionzButton.Location = New System.Drawing.Point(822, 67)
        Me.MissionVisionzButton.Name = "MissionVisionzButton"
        Me.MissionVisionzButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.MissionVisionzButton.OnDisabledState.BorderRadius = 40
        Me.MissionVisionzButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.MissionVisionzButton.OnDisabledState.BorderThickness = 1
        Me.MissionVisionzButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MissionVisionzButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.MissionVisionzButton.OnDisabledState.IconLeftImage = Nothing
        Me.MissionVisionzButton.OnDisabledState.IconRightImage = Nothing
        Me.MissionVisionzButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MissionVisionzButton.onHoverState.BorderRadius = 40
        Me.MissionVisionzButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.MissionVisionzButton.onHoverState.BorderThickness = 1
        Me.MissionVisionzButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MissionVisionzButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.MissionVisionzButton.onHoverState.IconLeftImage = Nothing
        Me.MissionVisionzButton.onHoverState.IconRightImage = Nothing
        Me.MissionVisionzButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.MissionVisionzButton.OnIdleState.BorderRadius = 40
        Me.MissionVisionzButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.MissionVisionzButton.OnIdleState.BorderThickness = 1
        Me.MissionVisionzButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MissionVisionzButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.MissionVisionzButton.OnIdleState.IconLeftImage = Nothing
        Me.MissionVisionzButton.OnIdleState.IconRightImage = Nothing
        Me.MissionVisionzButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.MissionVisionzButton.OnPressedState.BorderRadius = 40
        Me.MissionVisionzButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.MissionVisionzButton.OnPressedState.BorderThickness = 1
        Me.MissionVisionzButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.MissionVisionzButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.MissionVisionzButton.OnPressedState.IconLeftImage = Nothing
        Me.MissionVisionzButton.OnPressedState.IconRightImage = Nothing
        Me.MissionVisionzButton.Size = New System.Drawing.Size(254, 46)
        Me.MissionVisionzButton.TabIndex = 4
        Me.MissionVisionzButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MissionVisionzButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.MissionVisionzButton.TextMarginLeft = 0
        Me.MissionVisionzButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.MissionVisionzButton.UseDefaultRadiusAndThickness = True
        '
        'OrganizationChart
        '
        Me.OrganizationChart.AllowAnimations = True
        Me.OrganizationChart.AllowMouseEffects = True
        Me.OrganizationChart.AllowToggling = False
        Me.OrganizationChart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OrganizationChart.AnimationSpeed = 200
        Me.OrganizationChart.AutoGenerateColors = False
        Me.OrganizationChart.AutoRoundBorders = True
        Me.OrganizationChart.AutoSizeLeftIcon = True
        Me.OrganizationChart.AutoSizeRightIcon = True
        Me.OrganizationChart.BackColor = System.Drawing.Color.Transparent
        Me.OrganizationChart.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OrganizationChart.BackgroundImage = CType(resources.GetObject("OrganizationChart.BackgroundImage"), System.Drawing.Image)
        Me.OrganizationChart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrganizationChart.ButtonText = "Organizational Chart"
        Me.OrganizationChart.ButtonTextMarginLeft = 0
        Me.OrganizationChart.ColorContrastOnClick = 45
        Me.OrganizationChart.ColorContrastOnHover = 45
        Me.OrganizationChart.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.OrganizationChart.CustomizableEdges = BorderEdges4
        Me.OrganizationChart.DialogResult = System.Windows.Forms.DialogResult.None
        Me.OrganizationChart.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.OrganizationChart.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OrganizationChart.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.OrganizationChart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.OrganizationChart.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrganizationChart.ForeColor = System.Drawing.Color.White
        Me.OrganizationChart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrganizationChart.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.OrganizationChart.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.OrganizationChart.IconMarginLeft = 11
        Me.OrganizationChart.IconPadding = 10
        Me.OrganizationChart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrganizationChart.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.OrganizationChart.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.OrganizationChart.IconSize = 25
        Me.OrganizationChart.IdleBorderColor = System.Drawing.Color.Transparent
        Me.OrganizationChart.IdleBorderRadius = 44
        Me.OrganizationChart.IdleBorderThickness = 1
        Me.OrganizationChart.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OrganizationChart.IdleIconLeftImage = Nothing
        Me.OrganizationChart.IdleIconRightImage = Nothing
        Me.OrganizationChart.IndicateFocus = False
        Me.OrganizationChart.Location = New System.Drawing.Point(562, 67)
        Me.OrganizationChart.Name = "OrganizationChart"
        Me.OrganizationChart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.OrganizationChart.OnDisabledState.BorderRadius = 40
        Me.OrganizationChart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrganizationChart.OnDisabledState.BorderThickness = 1
        Me.OrganizationChart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.OrganizationChart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.OrganizationChart.OnDisabledState.IconLeftImage = Nothing
        Me.OrganizationChart.OnDisabledState.IconRightImage = Nothing
        Me.OrganizationChart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrganizationChart.onHoverState.BorderRadius = 40
        Me.OrganizationChart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrganizationChart.onHoverState.BorderThickness = 1
        Me.OrganizationChart.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrganizationChart.onHoverState.ForeColor = System.Drawing.Color.White
        Me.OrganizationChart.onHoverState.IconLeftImage = Nothing
        Me.OrganizationChart.onHoverState.IconRightImage = Nothing
        Me.OrganizationChart.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.OrganizationChart.OnIdleState.BorderRadius = 40
        Me.OrganizationChart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrganizationChart.OnIdleState.BorderThickness = 1
        Me.OrganizationChart.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OrganizationChart.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.OrganizationChart.OnIdleState.IconLeftImage = Nothing
        Me.OrganizationChart.OnIdleState.IconRightImage = Nothing
        Me.OrganizationChart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.OrganizationChart.OnPressedState.BorderRadius = 40
        Me.OrganizationChart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.OrganizationChart.OnPressedState.BorderThickness = 1
        Me.OrganizationChart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.OrganizationChart.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.OrganizationChart.OnPressedState.IconLeftImage = Nothing
        Me.OrganizationChart.OnPressedState.IconRightImage = Nothing
        Me.OrganizationChart.Size = New System.Drawing.Size(254, 46)
        Me.OrganizationChart.TabIndex = 3
        Me.OrganizationChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OrganizationChart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.OrganizationChart.TextMarginLeft = 0
        Me.OrganizationChart.TextPadding = New System.Windows.Forms.Padding(0)
        Me.OrganizationChart.UseDefaultRadiusAndThickness = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1124, 766)
        Me.Controls.Add(Me.MissionVisionzButton)
        Me.Controls.Add(Me.OrganizationChart)
        Me.Controls.Add(Me.BarangayDetailsButton)
        Me.Controls.Add(Me.AccountSettingsButton)
        Me.Controls.Add(Me.MainPanelSetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MissionVisionzButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents AccountSettingsButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents OrganizationChart As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents MainPanelSetting As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BarangayDetailsButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
