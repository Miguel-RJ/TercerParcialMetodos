<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbldf = New System.Windows.Forms.Label()
        Me.lblda = New System.Windows.Forms.Label()
        Me.lbldb = New System.Windows.Forms.Label()
        Me.lblcs = New System.Windows.Forms.Label()
        Me.lblrn = New System.Windows.Forms.Label()
        Me.lblrn2 = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.ta1 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Graficar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbmenu = New System.Windows.Forms.ComboBox()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldf
        '
        Me.lbldf.AutoSize = True
        Me.lbldf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldf.Location = New System.Drawing.Point(12, 64)
        Me.lbldf.Name = "lbldf"
        Me.lbldf.Size = New System.Drawing.Size(65, 20)
        Me.lbldf.TabIndex = 0
        Me.lbldf.Text = "Dame f:"
        '
        'lblda
        '
        Me.lblda.AutoSize = True
        Me.lblda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblda.Location = New System.Drawing.Point(12, 91)
        Me.lblda.Name = "lblda"
        Me.lblda.Size = New System.Drawing.Size(69, 20)
        Me.lblda.TabIndex = 1
        Me.lblda.Text = "Dame a:"
        '
        'lbldb
        '
        Me.lbldb.AutoSize = True
        Me.lbldb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldb.Location = New System.Drawing.Point(12, 118)
        Me.lbldb.Name = "lbldb"
        Me.lbldb.Size = New System.Drawing.Size(69, 20)
        Me.lbldb.TabIndex = 2
        Me.lbldb.Text = "Dame b:"
        '
        'lblcs
        '
        Me.lblcs.AutoSize = True
        Me.lblcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcs.Location = New System.Drawing.Point(12, 145)
        Me.lblcs.Name = "lblcs"
        Me.lblcs.Size = New System.Drawing.Size(147, 20)
        Me.lblcs.TabIndex = 3
        Me.lblcs.Text = "Cifras significativas:"
        '
        'lblrn
        '
        Me.lblrn.AutoSize = True
        Me.lblrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrn.Location = New System.Drawing.Point(12, 172)
        Me.lblrn.Name = "lblrn"
        Me.lblrn.Size = New System.Drawing.Size(113, 20)
        Me.lblrn.TabIndex = 4
        Me.lblrn.Text = "Rango gráfica:"
        '
        'lblrn2
        '
        Me.lblrn2.AutoSize = True
        Me.lblrn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrn2.Location = New System.Drawing.Point(196, 172)
        Me.lblrn2.Name = "lblrn2"
        Me.lblrn2.Size = New System.Drawing.Size(18, 20)
        Me.lblrn2.TabIndex = 5
        Me.lblrn2.Text = "a"
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(94, 64)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(196, 20)
        Me.tf.TabIndex = 6
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(94, 91)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(46, 20)
        Me.ta.TabIndex = 7
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(94, 118)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(46, 20)
        Me.tb.TabIndex = 8
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(195, 145)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(46, 20)
        Me.tc.TabIndex = 9
        '
        'ta1
        '
        Me.ta1.Location = New System.Drawing.Point(143, 172)
        Me.ta1.Name = "ta1"
        Me.ta1.Size = New System.Drawing.Size(46, 20)
        Me.ta1.TabIndex = 10
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(221, 172)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(46, 20)
        Me.tb1.TabIndex = 11
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(313, 61)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 12
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Graficar
        '
        Me.Graficar.Location = New System.Drawing.Point(313, 90)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Graficar.TabIndex = 13
        Me.Graficar.Text = "Graficar"
        Me.Graficar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(313, 119)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 14
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(313, 148)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 15
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(16, 227)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(343, 150)
        Me.salida.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "a"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Integrar"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        '
        'Graf
        '
        ChartArea2.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Graf.Legends.Add(Legend2)
        Me.Graf.Location = New System.Drawing.Point(404, 61)
        Me.Graf.Name = "Graf"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Me.Graf.Series.Add(Series3)
        Me.Graf.Series.Add(Series4)
        Me.Graf.Size = New System.Drawing.Size(373, 316)
        Me.Graf.TabIndex = 17
        Me.Graf.Text = "Chart1"
        '
        'cbmenu
        '
        Me.cbmenu.FormattingEnabled = True
        Me.cbmenu.Items.AddRange(New Object() {"Rectangulos", "Trapecios", "Simpson"})
        Me.cbmenu.Location = New System.Drawing.Point(16, 12)
        Me.cbmenu.Name = "cbmenu"
        Me.cbmenu.Size = New System.Drawing.Size(173, 21)
        Me.cbmenu.TabIndex = 18
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.cbmenu)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Graficar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.ta1)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lblrn2)
        Me.Controls.Add(Me.lblrn)
        Me.Controls.Add(Me.lblcs)
        Me.Controls.Add(Me.lbldb)
        Me.Controls.Add(Me.lblda)
        Me.Controls.Add(Me.lbldf)
        Me.Name = "Form_Principal"
        Me.Text = "Tercer Parcial"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldf As Label
    Friend WithEvents lblda As Label
    Friend WithEvents lbldb As Label
    Friend WithEvents lblcs As Label
    Friend WithEvents lblrn As Label
    Friend WithEvents lblrn2 As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents ta1 As TextBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Graficar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents cbmenu As ComboBox
End Class
