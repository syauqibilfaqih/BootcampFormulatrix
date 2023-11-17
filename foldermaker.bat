@echo off
setlocal enableDelayedExpansion
FOR /l %%N in (9,1,35) do (
    set "NUM=%%N"
    set "DIRNAME=Day!NUM:~-3!"
    md !DIRNAME!
)