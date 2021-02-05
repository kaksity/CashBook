; CashBook.nsi

!include "MUI.nsh"

!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "install_image.bmp"
;!insertmacro MUI_PAGE_WELCOME
;!insertmacro MUI_PAGE_LICENSE "EULA.txt"
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
;!insertmacro MUI_LANGUAGE "English"


Name "Cash Book Software"
OutFile "Cashbook_Setup.exe"
CRCCheck off
SetOverwrite off
Icon icon.ico
UnInstallIcon icon.ico

; The default installation directory
InstallDir $PROGRAMFILES\CashBook
; Registry key to check for directory (so if you install again, it will
; overwrite the old one automatically)
InstallDirRegKey HKLM SOFTWARE\BTF\CashBook "Install_Dir"

; The stuff to install

Section "Main Files (required)"

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR

  File "EULA.txt"
  File "Cash Book.exe"
  File "FirebirdSql.Data.FirebirdClient.dll"
  File "RdlEngine.DLL"
  File "Firebird-2.5.exe"
  File "RdlViewer.dll"
  File "dbO.dll"
  File "eztw32.dll"
  File "CASH BOOK.FDB"
  File "WriteAlias.exe"
  File "WriteAlias.exe.manifest"
  File "Cash Book.vshost.exe"
  ;File "Cash Book.vshost.exe.manifest"
  File "Cash Book.xml"
  File "accounts.rdl"
  File "transaction.rdl"
  File "transaction_description.rdl"
  File "bank_reconcilation.rdl"
    
  ;check for firebird installation in the registry
  ;if the registry key doesn't exist and error is raised and we jump to INST
  ;where firebird will be installed. If it exists we jump to CONT skipping
  ;the line calling the installer.

  ClearErrors
  ReadRegStr $0 HKLM "SOFTWARE\Firebird Project\Firebird Server\Instances" "DefaultInstance"
  IfErrors 0 +2
	goto INST
  goto CONT


  
  INST: ExecWait '"Firebird-2.5.exe" /VERYSILENT'

  CONT: Delete Firebird-2.5.exe

  ; Write the installation path into the registry

  WriteRegStr HKLM SOFTWARE\BTF\CaseFiles "Install_Dir" "$INSTDIR"

    ; Write the uninstall keys for Windows

WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Cash Book" "DisplayName" "CashBook Software (remove only)"
WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Cash Book" "UninstallString" '"$INSTDIR\uninstall.exe"'
WriteUninstaller "uninstall.exe"

 ExecWait '"WriteAlias.exe" Cash Book "$INSTDIR\CASH BOOK.FDB"'

SectionEnd

;-----------------------------------------------------------
Section "Start Menu Shortcuts"

  SetShellVarContext all

  CreateDirectory "$SMPROGRAMS\CashBook"

  CreateShortCut "$SMPROGRAMS\CashBook\Cash Book.lnk" "$INSTDIR\Cash Book.exe" "" "$INSTDIR\Cash Book.exe" 0

  CreateShortCut "$DESKTOP\Cash Book.lnk" "$INSTDIR\Cash Book.exe" "" "$INSTDIR\Cash Book.exe" 0

  CreateShortCut "$QUICKLAUNCH\Cash Book.lnk" "$INSTDIR\Cash Book.exe" "" "$INSTDIR\Cash Book.exe" 0
  
SectionEnd
;-----------------------------------------------------------

; uninstall stuff

UninstallText "This will uninstall Case Book Software Press Uninstall to continue."

; special uninstall section.--------------------------------

Section "Uninstall"


  ; remove registry keys

  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Cash Book"
;  DeleteRegKey HKLM SOFTWARE\BTF\CashBook

  ; remove files

  Delete $INSTDIR\CashBook.exe
  Delete $INSTDIR\*.dll

  ; MUST REMOVE UNINSTALLER, too

  Delete $INSTDIR\uninstall.exe

  ; remove shortcuts, if any.

  Delete "$SMPROGRAMS\Cash Book\*.*"
  Delete "$INSTDIR\*.*"
  Delete "$DESKTOP\Cash Book.lnk"
  Delete "$QUICKLAUNCH\Cash Book.lnk"

  ; remove directories used.

  RMDir "$SMPROGRAMS\Cash Book"
  RMDir "$INSTDIR"

SectionEnd
;----------------------------------------------------------
; eof