﻿Imports Aspose.Diagram
Imports System
Imports Aspose.Diagram.Saving
Public Class AutoFitShapesInVisio
    Public Shared Sub Run()
        ' ExStart:AutoFitShapesInVisio
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_Diagrams()

        ' Load a Visio diagram
        Dim diagram As New Diagram(dataDir & Convert.ToString("BFlowcht.vsdx"))

        ' Use saving options
        Dim options As New DiagramSaveOptions(SaveFileFormat.VSDX)
        ' Set Auto fit page property
        options.AutoFitPageToDrawingContent = True

        ' Save Visio diagram
        diagram.Save(dataDir & Convert.ToString("AutoFitShapesInVisio_out.vsdx"), options)
        ' ExEnd:AutoFitShapesInVisio
    End Sub
End Class
