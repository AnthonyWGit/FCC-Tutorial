@echo off
:start
setlocal enabledelayedexpansion

:commit
set "commit_message="
set /p "commit_message=Enter commit message (optional, max 72 chars): "

:: Length check with enforcement
if defined commit_message (
    set "msg=!commit_message!"
    set length=0
    :length_loop
    if not "!msg:~%length%,1!"=="" (
        set /a length+=1
        goto length_loop
    )
    
    if !length! gtr 72 (
        set /a overflow=length-72
        echo.
        echo ERROR: Message length !length!/72 (exceeds by !overflow!)
        echo First 72 chars: "!msg:~0,72!"
        echo Overflow:       "!msg:~72!"
        timeout /t 3 /nobreak >nul
        endlocal
        goto start
    )
)

:: Perform the commit with empty allowances
git commit -a --allow-empty --allow-empty-message -m "!commit_message!"
if errorlevel 1 (
    echo Commit failed! Check repository status.
    timeout /t 3 /nobreak >nul
    endlocal
    goto start
)

:: Push question
:push_question
set "push="
set /p "push=Do you want to push? (y/n): "
if /i "!push!"=="y" (
    git push
    endlocal
    goto start
) else if /i "!push!"=="n" (
    endlocal
    goto start
) else (
    echo Please answer y or n
    goto push_question
)