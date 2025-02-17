'Jacob Horsley
'RCET 0265
'Spring 2025
'Convert and Validate
'URL: https://github.com/horsjaco117/Convert-and-Validate

Option Strict On
Option Explicit On

Module ConvertandValidate

    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer 'This  defines the variables
        Dim userResponse As String

        Do

            Console.WriteLine($"Enter a number:")

            userResponse = Console.ReadLine()

            If ConversionValid(userResponse, aValidNumber) = True Then

                Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {userResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    'make this work


    Function ConversionValid(convertThisString As String, ByRef toThisInteger As Integer) As Boolean

        Try
            toThisInteger = Convert.ToInt32(convertThisString)
            Return True

        Catch ex As Exception
            toThisInteger = 0 'Reset the output variable to failure
            Return False

        End Try

        'Return status

    End Function


End Module
