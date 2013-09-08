set ver=0.9.5
xcopy lib\*.*  ..\packages\JDCB.%ver%\lib  /s /i /y 
xcopy tools\*.*  ..\packages\JDCB.%ver%\tools  /s /i /y 
BuildPublishPackage.cmd %ver%
