﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRD_List_Item
    'Inherits System.Windows.Forms.UserControl
    Inherits MetroFramework.Controls.MetroUserControl
    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PB_Thumbnail = New System.Windows.Forms.PictureBox()
        Me.bt_pause = New System.Windows.Forms.PictureBox()
        Me.bt_del = New System.Windows.Forms.PictureBox()
        Me.Label_Anime = New MetroFramework.Controls.MetroLabel()
        Me.Label_website = New MetroFramework.Controls.MetroLabel()
        Me.Label_Reso = New MetroFramework.Controls.MetroLabel()
        Me.Label_Hardsub = New MetroFramework.Controls.MetroLabel()
        Me.Label_percent = New MetroFramework.Controls.MetroLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewInExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaybackVideoFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogTocClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.PB_Thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_pause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_del, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Thumbnail
        '
        Me.PB_Thumbnail.BackColor = System.Drawing.SystemColors.Desktop
        Me.PB_Thumbnail.BackgroundImage = Global.Crunchyroll_Downloader.My.Resources.Resources.main_del
        Me.PB_Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_Thumbnail.Location = New System.Drawing.Point(11, 20)
        Me.PB_Thumbnail.Name = "PB_Thumbnail"
        Me.PB_Thumbnail.Size = New System.Drawing.Size(168, 95)
        Me.PB_Thumbnail.TabIndex = 0
        Me.PB_Thumbnail.TabStop = False
        '
        'bt_pause
        '
        Me.bt_pause.BackgroundImage = Global.Crunchyroll_Downloader.My.Resources.Resources.main_pause
        Me.bt_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_pause.Location = New System.Drawing.Point(740, 15)
        Me.bt_pause.Name = "bt_pause"
        Me.bt_pause.Size = New System.Drawing.Size(25, 20)
        Me.bt_pause.TabIndex = 1
        Me.bt_pause.TabStop = False
        '
        'bt_del
        '
        Me.bt_del.BackgroundImage = Global.Crunchyroll_Downloader.My.Resources.Resources.main_del
        Me.bt_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_del.Location = New System.Drawing.Point(775, 10)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(35, 29)
        Me.bt_del.TabIndex = 2
        Me.bt_del.TabStop = False
        '
        'Label_Anime
        '
        Me.Label_Anime.AutoSize = True
        Me.Label_Anime.BackColor = System.Drawing.Color.Transparent
        Me.Label_Anime.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label_Anime.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_Anime.Location = New System.Drawing.Point(195, 37)
        Me.Label_Anime.Name = "Label_Anime"
        Me.Label_Anime.Size = New System.Drawing.Size(243, 25)
        Me.Label_Anime.TabIndex = 3
        Me.Label_Anime.Text = "Anime Titel, Season, Episode "
        '
        'Label_website
        '
        Me.Label_website.AutoSize = True
        Me.Label_website.BackColor = System.Drawing.Color.Transparent
        Me.Label_website.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label_website.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_website.Location = New System.Drawing.Point(195, 10)
        Me.Label_website.Name = "Label_website"
        Me.Label_website.Size = New System.Drawing.Size(72, 25)
        Me.Label_website.TabIndex = 4
        Me.Label_website.Text = "website"
        '
        'Label_Reso
        '
        Me.Label_Reso.AutoSize = True
        Me.Label_Reso.BackColor = System.Drawing.Color.Transparent
        Me.Label_Reso.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label_Reso.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_Reso.Location = New System.Drawing.Point(195, 97)
        Me.Label_Reso.Name = "Label_Reso"
        Me.Label_Reso.Size = New System.Drawing.Size(63, 25)
        Me.Label_Reso.TabIndex = 5
        Me.Label_Reso.Text = "1080p"
        '
        'Label_Hardsub
        '
        Me.Label_Hardsub.AutoSize = True
        Me.Label_Hardsub.BackColor = System.Drawing.Color.Transparent
        Me.Label_Hardsub.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label_Hardsub.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_Hardsub.Location = New System.Drawing.Point(265, 97)
        Me.Label_Hardsub.Name = "Label_Hardsub"
        Me.Label_Hardsub.Size = New System.Drawing.Size(126, 25)
        Me.Label_Hardsub.TabIndex = 6
        Me.Label_Hardsub.Text = "Hardsub Label"
        '
        'Label_percent
        '
        Me.Label_percent.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label_percent.BackColor = System.Drawing.Color.Transparent
        Me.Label_percent.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label_percent.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label_percent.Location = New System.Drawing.Point(432, 97)
        Me.Label_percent.Name = "Label_percent"
        Me.Label_percent.Size = New System.Drawing.Size(378, 27)
        Me.Label_percent.TabIndex = 7
        Me.Label_percent.Text = "Status Label : speed, size and percent"
        Me.Label_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewInExplorerToolStripMenuItem, Me.PlaybackVideoFileToolStripMenuItem, Me.LogTocClipboard, Me.SaveToFile})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(190, 92)
        '
        'ViewInExplorerToolStripMenuItem
        '
        Me.ViewInExplorerToolStripMenuItem.Name = "ViewInExplorerToolStripMenuItem"
        Me.ViewInExplorerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ViewInExplorerToolStripMenuItem.Text = "View in explorer"
        '
        'PlaybackVideoFileToolStripMenuItem
        '
        Me.PlaybackVideoFileToolStripMenuItem.Name = "PlaybackVideoFileToolStripMenuItem"
        Me.PlaybackVideoFileToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PlaybackVideoFileToolStripMenuItem.Text = "playback video file"
        '
        'LogTocClipboard
        '
        Me.LogTocClipboard.Name = "LogTocClipboard"
        Me.LogTocClipboard.Size = New System.Drawing.Size(189, 22)
        Me.LogTocClipboard.Text = "Copy log to clipboard"
        '
        'SaveToFile
        '
        Me.SaveToFile.Name = "SaveToFile"
        Me.SaveToFile.Size = New System.Drawing.Size(189, 22)
        Me.SaveToFile.Text = "Save log to file"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Crunchyroll_Downloader.My.Resources.Resources.balken
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(0, 136)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(838, 6)
        Me.PictureBox5.TabIndex = 68
        Me.PictureBox5.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(195, 70)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(615, 20)
        Me.ProgressBar1.TabIndex = 9
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        '
        'CRD_List_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label_percent)
        Me.Controls.Add(Me.Label_Hardsub)
        Me.Controls.Add(Me.Label_Reso)
        Me.Controls.Add(Me.Label_website)
        Me.Controls.Add(Me.Label_Anime)
        Me.Controls.Add(Me.bt_del)
        Me.Controls.Add(Me.bt_pause)
        Me.Controls.Add(Me.PB_Thumbnail)
        Me.Name = "CRD_List_Item"
        Me.Size = New System.Drawing.Size(838, 142)
        CType(Me.PB_Thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_pause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_del, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_Thumbnail As PictureBox
    Friend WithEvents bt_pause As PictureBox
    Friend WithEvents bt_del As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ViewInExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaybackVideoFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents Label_Anime As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label_website As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label_Reso As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label_Hardsub As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label_percent As MetroFramework.Controls.MetroLabel
    Friend WithEvents LogTocClipboard As ToolStripMenuItem
    Friend WithEvents SaveToFile As ToolStripMenuItem
End Class
