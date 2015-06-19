Public Class UserInfo

    Private mTSName As String
    Public Property TSName As String
        Get
            Return mTSName
        End Get
        Set(value As String)
            mTSName = value
        End Set
    End Property

    Private mUserName As String
    Public Property UserName As String
        Get
            Return mUserName
        End Get
        Set(value As String)
            mUserName = value
        End Set
    End Property

    Private mUserId As Integer
    Public Property UserId As Integer
        Get
            Return mUserId
        End Get
        Set(value As Integer)
            mUserId = value
        End Set
    End Property

    Private mUserState As String
    Public Property UserState As String
        Get
            Return mUserState
        End Get
        Set(value As String)
            mUserState = value
        End Set
    End Property

    Private mPCName As String
    Public Property PCName As String
        Get
            Return mPCName
        End Get
        Set(value As String)
            mPCName = value
        End Set
    End Property


    Public Sub New()
        mTSName = String.Empty
        mUserName = String.Empty
        mUserId = 0
        mUserState = String.Empty
        mPCName = String.Empty
    End Sub

    Public Sub New(ByVal userName As String,
                   ByVal userId As Integer,
                   ByVal pcName As String,
                   Optional ByVal userState As String = "",
                   Optional ByVal tsName As String = "")
        mTSName = tsName
        mUserName = userName
        mUserId = userId
        mUserState = userState
        mPCName = pcName
    End Sub


End Class
