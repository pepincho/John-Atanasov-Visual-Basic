<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Easy
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
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckTick = New System.Windows.Forms.Timer(Me.components)
        Me.Pause = New System.Windows.Forms.Timer(Me.components)
        Me.Score = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OvalShape1
        '
        Me.OvalShape1.BackColor = System.Drawing.Color.Red
        Me.OvalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.OvalShape1.Location = New System.Drawing.Point(117, 106)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(50, 50)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(464, 330)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Bouncing_Ball_Animation.My.Resources.Resources.ani_walk_stickman
        Me.PictureBox2.Location = New System.Drawing.Point(388, 262)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'CheckTick
        '
        Me.CheckTick.Enabled = True
        Me.CheckTick.Interval = 1
        '
        'Pause
        '
        Me.Pause.Enabled = True
        Me.Pause.Interval = 10
        '
        'Score
        '
        Me.Score.Enabled = True
        Me.Score.Interval = 1
        '
        'Easy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(464, 330)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Easy"
        Me.Text = "Form4"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckTick As System.Windows.Forms.Timer
    Friend WithEvents Pause As System.Windows.Forms.Timer
    Friend WithEvents Score As System.Windows.Forms.Timer
End Class
