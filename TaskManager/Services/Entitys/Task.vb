Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.Entitys

    Public NotInheritable Class Task
        Inherits Entity

        Private _Isvaild As Boolean = True
        ReadOnly Property IsValid As Boolean
            Get
                Return _Isvaild
            End Get
        End Property

        Private _ErrorList As List(Of String) = New List(Of String)()

        ReadOnly Property ErrorList As List(Of String)
            Get
                Return _ErrorList
            End Get
        End Property

        Private _Id As Integer?

        Property Id As Integer
            Get
                Return _Id
            End Get
            Private Set(value As Integer)
                _Id = value
            End Set
        End Property

        Private _Title As String

        Property Title As String
            Get
                Return _Title
            End Get
            Private Set(value As String)
                If value IsNot Nothing Then
                    _Title = value
                End If
            End Set
        End Property

        Private _Created As DateTime

        Property Created As DateTime
            Get
                Return _Created
            End Get
            Private Set(value As DateTime)
                _Created = value
            End Set
        End Property

        Private _LastUpdate As DateTime

        Property LastUpdate As String
            Get
                Return _LastUpdate
            End Get
            Private Set(value As String)
                _LastUpdate = value
            End Set
        End Property

        Private _DueDate As DateTime
        Property DueDate As DateTime
            Get
                Return _DueDate
            End Get
            Private Set(value As DateTime)
                _DueDate = value
            End Set
        End Property

        Private _Status As EStatus
        Property Status As EStatus?
            Get
                Return _Status
            End Get
            Private Set(value As EStatus?)
                If value IsNot Nothing Then
                    _Status = value.Value
                End If
            End Set
        End Property

        Property UserId As Integer?
        ReadOnly Property User As User



        Sub New(title As String, dueDate As DateTime, userId As Integer)

            Me.Title = title
            Me.Created = DateTime.Now
            Me.LastUpdate = DateTime.Now
            Me.Status = EStatus.Pending
            Me.DueDate = dueDate
            Me.UserId = userId

        End Sub

        Sub New(id As Integer, title As String, created As DateTime, lastUpdate As DateTime, dueDate As DateTime, status As String, userId As Integer)

            Me.Id = id
            Me.Title = title
            Me.Created = created
            Me.LastUpdate = lastUpdate
            [Enum].TryParse(status, Me._Status)
            Me.DueDate = dueDate
            Me.UserId = userId

        End Sub




        Public Sub Update(title As String, dueDate As DateTime?, status As EStatus?)

            Me.Title = title
            Me.LastUpdate = DateTime.Now
            Me.Status = status
            Me.DueDate = dueDate

        End Sub

    End Class
End Namespace
