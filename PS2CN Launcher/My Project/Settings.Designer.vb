﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings 自动保存功能"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property ENLocaleVersion() As String
            Get
                Return CType(Me("ENLocaleVersion"),String)
            End Get
            Set
                Me("ENLocaleVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Games\PlanetSide 2\PlanetSide2_x64.exe"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property ENClientLocation() As String
            Get
                Return CType(Me("ENClientLocation"),String)
            End Get
            Set
                Me("ENClientLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property PingServer() As Byte
            Get
                Return CType(Me("PingServer"),Byte)
            End Get
            Set
                Me("PingServer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property CheckedCN() As Boolean
            Get
                Return CType(Me("CheckedCN"),Boolean)
            End Get
            Set
                Me("CheckedCN") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property Checked32bit() As Boolean
            Get
                Return CType(Me("Checked32bit"),Boolean)
            End Get
            Set
                Me("Checked32bit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property CheckedENVoice() As Boolean
            Get
                Return CType(Me("CheckedENVoice"),Boolean)
            End Get
            Set
                Me("CheckedENVoice") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property ClientType() As Byte
            Get
                Return CType(Me("ClientType"),Byte)
            End Get
            Set
                Me("ClientType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TESTLocaleVersion() As String
            Get
                Return CType(Me("TESTLocaleVersion"),String)
            End Get
            Set
                Me("TESTLocaleVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Games\PlanetSide 2 Test\PlanetSide2_x64.exe"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TESTClientLLocation() As String
            Get
                Return CType(Me("TESTClientLLocation"),String)
            End Get
            Set
                Me("TESTClientLLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property KORLocaleVersionEN() As String
            Get
                Return CType(Me("KORLocaleVersionEN"),String)
            End Get
            Set
                Me("KORLocaleVersionEN") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Games\PlanetSide 2 KOR\PlanetSide2_x64.exe"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property KORClientLLocation() As String
            Get
                Return CType(Me("KORClientLLocation"),String)
            End Get
            Set
                Me("KORClientLLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property RULocaleVersionEN() As String
            Get
                Return CType(Me("RULocaleVersionEN"),String)
            End Get
            Set
                Me("RULocaleVersionEN") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Games\PlanetSide 2 RU\PlanetSide2_x64.exe"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property RUClientLLocation() As String
            Get
                Return CType(Me("RUClientLLocation"),String)
            End Get
            Set
                Me("RUClientLLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property KORLocaleVersionKOR() As String
            Get
                Return CType(Me("KORLocaleVersionKOR"),String)
            End Get
            Set
                Me("KORLocaleVersionKOR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute(""),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property RULocaleVersionRU() As String
            Get
                Return CType(Me("RULocaleVersionRU"),String)
            End Get
            Set
                Me("RULocaleVersionRU") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("4"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TimeZone1() As Byte
            Get
                Return CType(Me("TimeZone1"),Byte)
            End Get
            Set
                Me("TimeZone1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TimeZone2() As Byte
            Get
                Return CType(Me("TimeZone2"),Byte)
            End Get
            Set
                Me("TimeZone2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TimeZone3() As Byte
            Get
                Return CType(Me("TimeZone3"),Byte)
            End Get
            Set
                Me("TimeZone3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("6"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TimeHour() As Byte
            Get
                Return CType(Me("TimeHour"),Byte)
            End Get
            Set
                Me("TimeHour") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property CheckedDST1() As Boolean
            Get
                Return CType(Me("CheckedDST1"),Boolean)
            End Get
            Set
                Me("CheckedDST1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property CheckedDST2() As Boolean
            Get
                Return CType(Me("CheckedDST2"),Boolean)
            End Get
            Set
                Me("CheckedDST2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property CheckedDST3() As Boolean
            Get
                Return CType(Me("CheckedDST3"),Boolean)
            End Get
            Set
                Me("CheckedDST3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property TimeSelection() As Byte
            Get
                Return CType(Me("TimeSelection"),Byte)
            End Get
            Set
                Me("TimeSelection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property FunctionSelector() As Byte
            Get
                Return CType(Me("FunctionSelector"),Byte)
            End Get
            Set
                Me("FunctionSelector") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Configuration.SettingsProviderAttribute(GetType(PS2CN_Launcher.PortableSettingsProvider)),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("使用默认字体"),  _
         Global.System.Configuration.SettingsManageabilityAttribute(Global.System.Configuration.SettingsManageability.Roaming)>  _
        Public Property FontSelector() As String
            Get
                Return CType(Me("FontSelector"),String)
            End Get
            Set
                Me("FontSelector") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CheckedAutoRestore() As Boolean
            Get
                Return CType(Me("CheckedAutoRestore"),Boolean)
            End Get
            Set
                Me("CheckedAutoRestore") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property CheckedShowFunctionUI() As Boolean
            Get
                Return CType(Me("CheckedShowFunctionUI"),Boolean)
            End Get
            Set
                Me("CheckedShowFunctionUI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("D:\Games\Steam\SteamApps\common\PlanetSide 2\PlanetSide2_x64.exe")>  _
        Public Property STEAMClientLocation() As String
            Get
                Return CType(Me("STEAMClientLocation"),String)
            End Get
            Set
                Me("STEAMClientLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property STEAMLocaleVersion() As String
            Get
                Return CType(Me("STEAMLocaleVersion"),String)
            End Get
            Set
                Me("STEAMLocaleVersion") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.PS2CN_Launcher.My.MySettings
            Get
                Return Global.PS2CN_Launcher.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
