Option Strict On
Public Class Car
    Private Shared carCount As Integer
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As String
    Private carPrice As String
    Private carNewStatus As Boolean = False

    Public Sub New()

        carCount += 1      ' increment the counter variable by 1
        carIdentificationNumber = carCount ' give the car and id number

    End Sub

    Public Sub New(make As String, model As String, year As String, price As String, newstatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        carMake = make         ' set the cars make
        carModel = model  ' set the cars model
        carYear = year    ' set the cars year
        carPrice = price 'set the cars price
        carNewStatus = newstatus        ' set the cars new status

    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    Public Property NewStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property

    Public Function GetInformation() As String

        Return "The car is a " & carYear & " " & carMake & " " & carModel & ", " & IIf(carNewStatus = True, "It is new", "It is used").ToString() & " and costs " & carPrice

    End Function
End Class
