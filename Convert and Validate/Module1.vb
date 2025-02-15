Module Module1

    Sub Main()

        'for testing the function add this to your Sub Main()

        Dim aValidNumber As Integer
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

        Dim status As Boolean

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
