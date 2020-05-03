; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "DS-Timer"
#define MyAppVersion "1.8.0.0"
#define MyAppPublisher "DaWolf85"
#define MyAppURL "https://github.com/Niondir/ds-timer"
#define MyAppExeName "DS-Timer.exe"
#define MySourceDir "1_8_0_0"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C93F8F79-128F-483E-93D9-A7744F8A66BD}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir="D:\Google Drive\TribalWars\DS-Timer Releases"
OutputBaseFilename=ds-timer_setup
;Password=nightmare
;Encryption=yes
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\Google Drive\TribalWars\DS-Timer Releases\sources\{#MySourceDir}\DS-Timer.exe"; DestDir: "{app}"; Flags: ignoreversion
;Source: "D:\Google Drive\TribalWars\DS-Timer Releases\sources\{#MySourceDir}\DS-Timer.exe.en.config"; DestDir: {app}; Flags: ignoreversion; Languages: english; DestName: DS-Timer.exe.config; 
;Source: "D:\Google Drive\TribalWars\DS-Timer Releases\sources\{#MySourceDir}\DS-Timer.exe.de.config"; DestDir: {app}; Flags: ignoreversion; Languages: german; DestName: DS-Timer.exe.config; 
Source: "D:\Google Drive\TribalWars\DS-Timer Releases\sources\{#MySourceDir}\*"; DestDir: {app}; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: DS-Timer.exe.*.config; 



; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, "&", "&&")}}"; Flags: nowait postinstall skipifsilent

