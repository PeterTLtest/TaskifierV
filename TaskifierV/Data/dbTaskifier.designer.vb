﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.1
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


Partial Public Class TaskifierDB
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definitionen der Erweiterungsmethoden"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertLogEntries(instance As LogEntries)
    End Sub
  Partial Private Sub UpdateLogEntries(instance As LogEntries)
    End Sub
  Partial Private Sub DeleteLogEntries(instance As LogEntries)
    End Sub
  Partial Private Sub InsertLogEntriesToTags(instance As LogEntriesToTags)
    End Sub
  Partial Private Sub UpdateLogEntriesToTags(instance As LogEntriesToTags)
    End Sub
  Partial Private Sub DeleteLogEntriesToTags(instance As LogEntriesToTags)
    End Sub
  Partial Private Sub InsertTags(instance As Tags)
    End Sub
  Partial Private Sub UpdateTags(instance As Tags)
    End Sub
  Partial Private Sub DeleteTags(instance As Tags)
    End Sub
  #End Region
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property LogEntries() As System.Data.Linq.Table(Of LogEntries)
		Get
			Return Me.GetTable(Of LogEntries)
		End Get
	End Property
	
	Public ReadOnly Property LogEntriesToTags() As System.Data.Linq.Table(Of LogEntriesToTags)
		Get
			Return Me.GetTable(Of LogEntriesToTags)
		End Get
	End Property
	
	Public ReadOnly Property Tags() As System.Data.Linq.Table(Of Tags)
		Get
			Return Me.GetTable(Of Tags)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute()>  _
Partial Public Class LogEntries
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _LogType As String
	
	Private _Name As String
	
	Private _Description As String
	
	Private _Priority As String
	
	Private _StartDate As System.Nullable(Of Date)
	
	Private _EndDate As System.Nullable(Of Date)
	
	Private _Active As Boolean
	
	Private _InProgress As System.Nullable(Of Boolean)
	
	Private _Finished As System.Nullable(Of Boolean)
	
    #Region "Definitionen der Erweiterungsmethoden"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnLogTypeChanging(value As String)
    End Sub
    Partial Private Sub OnLogTypeChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnDescriptionChanged()
    End Sub
    Partial Private Sub OnPriorityChanging(value As String)
    End Sub
    Partial Private Sub OnPriorityChanged()
    End Sub
    Partial Private Sub OnStartDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnStartDateChanged()
    End Sub
    Partial Private Sub OnEndDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnEndDateChanged()
    End Sub
    Partial Private Sub OnActiveChanging(value As Boolean)
    End Sub
    Partial Private Sub OnActiveChanged()
    End Sub
    Partial Private Sub OnInProgressChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnInProgressChanged()
    End Sub
    Partial Private Sub OnFinishedChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnFinishedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LogType", DbType:="NVarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property LogType() As String
		Get
			Return Me._LogType
		End Get
		Set
			If (String.Equals(Me._LogType, value) = false) Then
				Me.OnLogTypeChanging(value)
				Me.SendPropertyChanging
				Me._LogType = value
				Me.SendPropertyChanged("LogType")
				Me.OnLogTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="NVarChar(4000)")>  _
	Public Property Description() As String
		Get
			Return Me._Description
		End Get
		Set
			If (String.Equals(Me._Description, value) = false) Then
				Me.OnDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._Description = value
				Me.SendPropertyChanged("Description")
				Me.OnDescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Priority", DbType:="NVarChar(10)")>  _
	Public Property Priority() As String
		Get
			Return Me._Priority
		End Get
		Set
			If (String.Equals(Me._Priority, value) = false) Then
				Me.OnPriorityChanging(value)
				Me.SendPropertyChanging
				Me._Priority = value
				Me.SendPropertyChanged("Priority")
				Me.OnPriorityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartDate", DbType:="DateTime")>  _
	Public Property StartDate() As System.Nullable(Of Date)
		Get
			Return Me._StartDate
		End Get
		Set
			If (Me._StartDate.Equals(value) = false) Then
				Me.OnStartDateChanging(value)
				Me.SendPropertyChanging
				Me._StartDate = value
				Me.SendPropertyChanged("StartDate")
				Me.OnStartDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndDate", DbType:="DateTime")>  _
	Public Property EndDate() As System.Nullable(Of Date)
		Get
			Return Me._EndDate
		End Get
		Set
			If (Me._EndDate.Equals(value) = false) Then
				Me.OnEndDateChanging(value)
				Me.SendPropertyChanging
				Me._EndDate = value
				Me.SendPropertyChanged("EndDate")
				Me.OnEndDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Active", DbType:="Bit NOT NULL")>  _
	Public Property Active() As Boolean
		Get
			Return Me._Active
		End Get
		Set
			If ((Me._Active = value)  _
						= false) Then
				Me.OnActiveChanging(value)
				Me.SendPropertyChanging
				Me._Active = value
				Me.SendPropertyChanged("Active")
				Me.OnActiveChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_InProgress", DbType:="Bit")>  _
	Public Property InProgress() As System.Nullable(Of Boolean)
		Get
			Return Me._InProgress
		End Get
		Set
			If (Me._InProgress.Equals(value) = false) Then
				Me.OnInProgressChanging(value)
				Me.SendPropertyChanging
				Me._InProgress = value
				Me.SendPropertyChanged("InProgress")
				Me.OnInProgressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Finished", DbType:="Bit")>  _
	Public Property Finished() As System.Nullable(Of Boolean)
		Get
			Return Me._Finished
		End Get
		Set
			If (Me._Finished.Equals(value) = false) Then
				Me.OnFinishedChanging(value)
				Me.SendPropertyChanging
				Me._Finished = value
				Me.SendPropertyChanged("Finished")
				Me.OnFinishedChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute()>  _
Partial Public Class LogEntriesToTags
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _LogEntryId As Integer
	
	Private _TagId As Integer
	
	Private _Active As Boolean
	
    #Region "Definitionen der Erweiterungsmethoden"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnLogEntryIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnLogEntryIdChanged()
    End Sub
    Partial Private Sub OnTagIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnTagIdChanged()
    End Sub
    Partial Private Sub OnActiveChanging(value As Boolean)
    End Sub
    Partial Private Sub OnActiveChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LogEntryId", DbType:="Int NOT NULL")>  _
	Public Property LogEntryId() As Integer
		Get
			Return Me._LogEntryId
		End Get
		Set
			If ((Me._LogEntryId = value)  _
						= false) Then
				Me.OnLogEntryIdChanging(value)
				Me.SendPropertyChanging
				Me._LogEntryId = value
				Me.SendPropertyChanged("LogEntryId")
				Me.OnLogEntryIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TagId", DbType:="Int NOT NULL")>  _
	Public Property TagId() As Integer
		Get
			Return Me._TagId
		End Get
		Set
			If ((Me._TagId = value)  _
						= false) Then
				Me.OnTagIdChanging(value)
				Me.SendPropertyChanging
				Me._TagId = value
				Me.SendPropertyChanged("TagId")
				Me.OnTagIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Active", DbType:="Bit NOT NULL")>  _
	Public Property Active() As Boolean
		Get
			Return Me._Active
		End Get
		Set
			If ((Me._Active = value)  _
						= false) Then
				Me.OnActiveChanging(value)
				Me.SendPropertyChanging
				Me._Active = value
				Me.SendPropertyChanged("Active")
				Me.OnActiveChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute()>  _
Partial Public Class Tags
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Name As String
	
	Private _Active As Boolean
	
    #Region "Definitionen der Erweiterungsmethoden"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnActiveChanging(value As Boolean)
    End Sub
    Partial Private Sub OnActiveChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(100)")>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Active", DbType:="Bit NOT NULL")>  _
	Public Property Active() As Boolean
		Get
			Return Me._Active
		End Get
		Set
			If ((Me._Active = value)  _
						= false) Then
				Me.OnActiveChanging(value)
				Me.SendPropertyChanging
				Me._Active = value
				Me.SendPropertyChanged("Active")
				Me.OnActiveChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class