﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function

        Function About() As ActionResult
            Return View()
        End Function

        Function Contact() As ActionResult
            Return View()
        End Function


    End Class
End Namespace